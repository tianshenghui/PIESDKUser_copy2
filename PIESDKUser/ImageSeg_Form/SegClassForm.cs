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
        //RuleSetMessage ruleSetMessage = new RuleSetMessage();
        
        //public string imagepath;
        //public string rulesetpath;
        //[DllImport("SampleAMIEngine.dll", EntryPoint = "?AnalyseImage@@YA_NPEBD00@Z")]
        //public static extern bool AnalyseImageCsharp(string imagePath, string rulePath);
        //public static Task<bool> Analyse(string imagepath, string rulepath)
        //{
        //    return new Task<bool>(() => AnalyseImageCsharp(imagepath, rulepath));
        //}
        //bool testfun()
        //{
        //    Thread.Sleep(10000);
        //    return true;
        //}
        private bool NotcancelFlag=true;
        //private CancellationTokenSource ct;
        private void MulSegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SegSetting segSetting = new SegSetting();
            segSetting.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //SegSetting segSetting = new SegSetting();
            //segSetting.ShowDialog();
        }
        Task<int> AnalyseImageAsync(string imagePath,string rulesetPath,string project,string projectName)
        {
            //backgroundWorker = new BackgroundWorker();
            //backgroundWorker.WorkerReportsProgress = true;
            //var tokenSource = new CancellationTokenSource();
            //CancellationToken ct = tokenSource.Token;
          return Task.Run(() =>
                Class1.AnalyseImage(imagePath, rulesetPath,project,projectName));
            
        }
        Task<bool> FTPdownloadAsync(string FTPURL, string filePath, string FTPusername, string FTPpassword, ProgressBar pb)
        {
            return Task.Run(() =>
                  FTPdownload.Download(FTPURL, filePath,FTPusername,FTPpassword,pb));

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
            if (openFileDialog2.ShowDialog()== DialogResult.OK)
            {
                tb_ruleset.Text = openFileDialog2.FileName;
                RuleSetMessage.RuleSetPath = openFileDialog2.FileName;
            }
            //openFileDialog2.AutoUpgradeEnabled = true;
            //tb_ruleset.Text = openFileDialog.FileName;
            //SegLib.RuleSet = openFileDialog.FileName;
            //rulesetpath=Path.GetFullPath(openFileDialog.FileName);
            
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
            //openFileDialog1.Disposed += LoadImage;
            //openFileDialog1.AutoUpgradeEnabled = true;
            //SegLib.image= openFileDialog.FileName;
            //imagepath =Path.GetFullPath(openFileDialog.FileName);
           
        }
        
        private async void bn_Execute_Click(object sender, EventArgs e)
        {
            
            //progressBar1.Visible = true;
            //progressBar.Visible = true;
            
            //Button button = sender as Button;
            //button.UseWaitCursor = true;
            //string imagepath = "D:\\EC\\data.tif";
            //string rulepath = "D:\\EC\\testvv.dcp";
            //textBox1.Text = imagePath;
            //AnalyseImageCsharp(image, rule);
            string imagepath = tb_image.Text;
            if (imagepath == "")
            {
                MessageBox.Show("请加载要处理的影像！");
                return;
            }
            string rulepath = tb_ruleset.Text;
            if(rulepath=="")
            {
                MessageBox.Show("请加载规则集！");
                return;
            }
            XmlInfo classDet = new XmlInfo(rulepath);
            classDet.ReadRuleSet();
            string OutShpPath = classDet.SearchAlgoParams();
            string ClassficationPath = classDet.SearchAlgoParams2();
            if (OutShpPath==""&&ClassficationPath=="")
            {
                MessageBox.Show("此规则集有误，或本系统暂不支持该规则集，\n请修改规则集并重试！");
                return;
            }
            //else if (ClassficationPath != "")
            //{
            //    MessageBox.Show("此规则集用于分类，请先在分类参数窗口中\n" +
            //            "进行相关设置，并点击确定按钮！");
            //    return;
            //}

            //if(segDet!=null&&RuleSetMessage.OutShpPath==null)
            //{
            //    MessageBox.Show("此规则集用于分割，请先在多尺度分割参数窗口中\n" +
            //            "进行相关设置，并点击确定按钮！");
            //    return;
            //}
            if (RuleSetMessage.AlgoOptions != 1 && RuleSetMessage.AlgoOptions != 2)
            {
                if (ClassficationPath!="")
                {
                    MessageBox.Show("此规则集用于分类，请先在分类参数窗口中\n" +
                        "进行相关设置，并点击确定按钮！");
                    return;
                }
                else if (OutShpPath!="")
                {
                    MessageBox.Show("此规则集用于分割，请先在多尺度分割参数窗口中\n" +
                        "进行相关设置，并点击确定按钮！");
                    return;
                }
            }
            string project = tb_projectPath.Text;
            string projectName = tb_projetName.Text;
            Lb_result.Text = "开始执行";
            //Func<string, string, bool> func = AnalyseImageCsharp;
            //Task<bool> task = new Task<bool>(() => AnalyseImageCsharp(imagepath, rulepath));
            //task.Start();
            //task.Wait();
            //MethodInvoker methodInvoker = () => AnalyseImageCsharp(imagepath, rulepath);
            //methodInvoker();
            //Thread.Sleep(10);
            //bool result=func(imagepath,rulepath);
            //bool result = testfun();
            //button.UseWaitCursor = false;
            //bool result = AnalyseImageCsharp(imagepath, rulepath);
            //progressbarUpdate update = ProgressbarStatus;
            //progressBar1.BeginInvoke(update);
            //progressBar1.
            //try
            //{
            //string project = "D:\\EC\\temptest";
            //string projectName = "third";
            Task t2 = ProgressbarStatus();
                Task<int> t1 = AnalyseImageAsync(imagepath, rulepath,project,projectName);
                await Task.WhenAny(t1, t2);


                //int result=Class1.AnalyseImage(imagepath, rulepath);
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
            //}
            //catch(Exception ex)
            //{
            //    Lb_result.Text = ex.Message;
            //}
            
        //    backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
        //    backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        //    backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }
        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    backgroundWorker.ReportProgress(0, "开始执行...");
        //    backgroundWorker.ReportProgress(100, "完成！");
        //}
        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
   
        //    toolStripProgressBar1.Enabled = false;
            

        //}
        //private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    toolStripProgressBar1.Value = e.ProgressPercentage;
        //    toolStripStatusLabel1.Text = e.UserState as String;
        //}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void lb_ruleset_Click(object sender, EventArgs e)
        {

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

        private void Tb_FTPusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_Download_Path_TextChanged(object sender, EventArgs e)
        {

        }

        private async void bn_downFile2_Click(object sender, EventArgs e)
        {
            string BaseFTPpath = tb_FTPpath2.Text;
            string FTPusername = tb_username2.Text;
            string FTPpassword = tb_password2.Text;
            string FTPoutpath = tb_filedownPath2.Text;
            string fileRelatedInfo = tb_fileRelatedInfo.Text;
            FTPdownload ftp = new FTPdownload(FTPusername,FTPpassword,BaseFTPpath);
            await FTPdownloadAllAsync(BaseFTPpath, FTPoutpath, fileRelatedInfo, FTPusername, FTPpassword, Pb_download);
        }

        private void Bn_SaveAllFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "将下载的影像文件保存到";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_filedownPath2.Text= folderBrowserDialog1.SelectedPath+"\\";
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


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int a = 10;
        //    for(int i=0;i<100;i++)
        //    {
        //        a += i;
        //    }
        //}
    }
}
