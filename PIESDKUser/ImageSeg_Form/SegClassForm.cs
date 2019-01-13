using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AnalyseImageCshap;
using System.Threading;
using System.Runtime.InteropServices;
using PIE.Plugin;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.Carto;
using PIE.DataSource;
using PIE.Controls;
namespace Sparkle
{
    public partial class SegClassForm : Form
    {
        public SegClassForm()
        {
            InitializeComponent();
        }
        private bool NotcancelFlag = true;
        private static CancellationTokenSource tokenSource2 = new CancellationTokenSource();
        private CancellationToken ct = tokenSource2.Token;
        private void MulSegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SegSetting segSetting = new SegSetting();
            segSetting.ShowDialog();
        }
        Task<int> AnalyseImageAsync(string imagePath, string rulesetPath, string project, string projectName)
        {
            return Task.Run(() =>
                  Class1.AnalyseImage(imagePath, rulesetPath, project, projectName));

        }
        //用于任务取消
        Task<int> AnalyseImageAsync2(string imagePath, string rulesetPath, string project, string projectName)
        {
            var task= Task<int>.Factory.StartNew(() => {
                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }
                int result=Class1.AnalyseImage(imagePath, rulesetPath, project, projectName);
                return result;
            },tokenSource2.Token);
            return task;
        }
        Task<bool> FTPdownloadAsync(string FTPURL, string filePath, string FTPusername, string FTPpassword, ProgressBar pb)
        {
            return Task.Run(() =>
                  FTPdownload.Download(FTPURL, filePath, FTPusername, FTPpassword, pb));

        }
        Task FTPdownloadAllAsync(string baseFTPpath, string filePath, string related, string FTPusername, string FTPpassword, ProgressBar pb)
        {
            FTPdownload ftp = new FTPdownload(FTPusername, FTPpassword, baseFTPpath);
            return Task.Run(() => ftp.DownloadAllRelated(baseFTPpath, filePath, related, pb));
        }
        private void bn_LoadRuleSet_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "加载规则集文件";
            openFileDialog2.Filter = "规则集文件|*.dcp";
            openFileDialog2.RestoreDirectory = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                tb_ruleset.Text = openFileDialog2.FileName;
                RuleSetMessage.RuleSetPath = openFileDialog2.FileName;
            }
        }
        private void LoadImage(object sender, EventArgs e)
        {
            ExecuteEC executeEC = new ExecuteEC();
            executeEC.OnCreate(MainForm.parentForm.axMapControl2);
            executeEC.OnClick();
        }
        private void bn_LoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "加载影像";
            openFileDialog1.Filter = "栅格数据|*.tif;*.tiff;*.img";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_image.Text = openFileDialog1.FileName;
                RuleSetMessage.imagePath = openFileDialog1.FileName;
                if (RuleSetMessage.imagePath != null)
                {
                    ILayer layer = LayerFactory.CreateDefaultLayer(RuleSetMessage.imagePath);
                    MainForm.parentForm.axMapControl2.FocusMap.AddLayer(layer);
                    MainForm.parentForm.axMapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                }
            }
        }
        private async void bn_Execute_Click(object sender, EventArgs e)
        {
            string imagepath = tb_image.Text;
            if (imagepath == "")
            {
                MessageBox.Show("请加载要处理的影像！");
                return;
            }
            string rulepath = tb_ruleset.Text;
            if (rulepath == "")
            {
                MessageBox.Show("请加载规则集！");
                return;
            }
            XmlInfo classDet = new XmlInfo(rulepath);
            classDet.ReadRuleSet();
            string OutShpPath = classDet.SearchAlgoParams();
            string ClassficationPath = classDet.SearchAlgoParams2();
            if (OutShpPath == "" && ClassficationPath == "")
            {
                MessageBox.Show("此规则集有误，或本系统暂不支持该规则集，\n请修改规则集并重试！");
                return;
            }
            if (RuleSetMessage.AlgoOptions != 1 && RuleSetMessage.AlgoOptions != 2)
            {
                if (ClassficationPath != "")
                {
                    MessageBox.Show("此规则集用于分类，请先在分类参数窗口中\n" +
                        "进行相关设置，并点击确定按钮！");
                    return;
                }
                else if (OutShpPath != "")
                {
                    MessageBox.Show("此规则集用于分割，请先在多尺度分割参数窗口中\n" +
                        "进行相关设置，并点击确定按钮！");
                    return;
                }
            }
            string project = tb_projectPath.Text;
            string projectName = tb_projetName.Text;
            Lb_result.Text = "开始执行";
            Task t2 = ProgressbarStatus();
            Task<int> t1 = AnalyseImageAsync2(imagepath, rulepath, project, projectName);
            await Task.WhenAny(t1, t2);
            if (t1.Result == 0)
            {
                Lb_result.Text = "执行成功";
                RuleSetMessage.AlgoOptions = 0;
                NotcancelFlag = false;
                Console.Beep(1000, 1000);
                MessageBox.Show("完成");
                Close();
            }
            else
            {
                Lb_result.Text = "执行失败,错误码为：" + t1.Result.ToString();
                RuleSetMessage.AlgoOptions = 0;
                NotcancelFlag = false;
                progressBar1.Visible = false;
            }
        }
        private delegate void progressbarUpdate();
        private Task ProgressbarStatus() => Task.Run(() =>
                                          {
                                              int i = 0;
                                              while (NotcancelFlag)
                                              {
                                                  i++;
                                                  progressBar1.Value = i;
                                                  if (i == progressBar1.Maximum)
                                                  {
                                                      i = 0;
                                                  }
                                                  Thread.Sleep(60);
                                              }
                                              progressBar1.Value = 0;
                                              progressBar1.Visible = false;
                                          });

        private void ClassSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassSettingForm classSetting = new ClassSettingForm();
            classSetting.ShowDialog();
        }
        private async void Bn_FTPdownload_Click(object sender, EventArgs e)
        {
            string FTPpath = Tb_FTPpath.Text;
            string FTPusername = Tb_FTPusername.Text;
            string FTPpassword = Tb_FTPpassword.Text;
            string FTPoutpath = Tb_Download_Path.Text;
            await FTPdownloadAsync(FTPpath, FTPoutpath, FTPusername, FTPpassword, Pb_download);
        }

        private void Bn_SaveDownload_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "保存下载后的影像文件";
            saveFileDialog1.Filter = "文件|*.img;*.tif";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Tb_Download_Path.Text = saveFileDialog1.FileName;
            }
        }
        private async void bn_downFile2_Click(object sender, EventArgs e)
        {
            string BaseFTPpath = tb_FTPpath2.Text;
            string FTPusername = tb_username2.Text;
            string FTPpassword = tb_password2.Text;
            string FTPoutpath = tb_filedownPath2.Text;
            string fileRelatedInfo = tb_fileRelatedInfo.Text;
            FTPdownload ftp = new FTPdownload(FTPusername, FTPpassword, BaseFTPpath);
            await FTPdownloadAllAsync(BaseFTPpath, FTPoutpath, fileRelatedInfo, FTPusername, FTPpassword, Pb_download);
        }
        private void Bn_SaveAllFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "将下载的影像文件保存到";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_filedownPath2.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }
        private void bn_SaveProj_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "将项目文件保存到";
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                tb_projectPath.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void bn_CancelTask_Click(object sender, EventArgs e)
        {
            tokenSource2?.Cancel();
        }
    }
}
