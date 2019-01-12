using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Sparkle
{
    public partial class ClassSettingForm : Form
    {
        public ClassSettingForm()
        {
            InitializeComponent();
        }

        //类名
        List<string> classname = new List<string>();
        XmlInfo classDet = new XmlInfo(RuleSetMessage.RuleSetPath);


        /// <summary>
        /// 产生随机颜色
        /// </summary>
        /// <returns></returns>
        public int[] generateColor()
        {
            int[] color = new int[3];

            color[0] = new Random().Next(255);  //R
            color[1] = new Random().Next(255);  //G
            color[2] = new Random().Next(255);   //B
            color[2] = (color[0] + color[1] > 400) ? color[0] + color[1] - 400 : color[2];
            color[2] = (color[2] > 255) ? 255 : color[2];

            return color;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //显示颜色和类名
            if (classDet.ReadRuleSet())
            {
                classname = classDet.LoadClassInfo();
                var classColor = classDet.ObtainClassColor();
                for (int i = 0; i < classname.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //DataGridViewColumn column = new DataGridViewColumn();
                    //int[] color = generateColor();
                    
                    //int rowIndex = dgvClassDetail.Columns.Add(column);
                    int index = this.dgvClassDetail.Rows.Add(row);
                    this.dgvClassDetail.Rows[index].Cells[1].Style.BackColor = 
                        Color.FromArgb(classColor[i].Item1, classColor[i].Item2, classColor[i].Item3);
                    this.dgvClassDetail.Rows[index].Cells[0].Value = classname[i];
                    this.dgvClassDetail.Rows[index].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    color = null;
                }
                //RuleSetMessage.OutClassResultsPath = tb_outputPath.Text;
                string outPath = classDet.SearchAlgoParams2();
                tb_outputPath.Text = ParseOutPathRe(outPath);
                //string changedOutPath = ChangeOutPath(ref outPath, RuleSetMessage.OutClassResultsPath);
                //classDet.ChangeoutPath2(changedOutPath);
            }
            else
                return;
        }

        /// <summary>
        /// 单击颜色单元格时弹出颜色框，选择颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClassDetail_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                return;
            }
            DataGridViewCell cell = this.dgvClassDetail.Rows[e.RowIndex].Cells[1];
            if (cell == null || cell.Style.BackColor == null)
            {
                return;
            }

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string r = colorDialog1.Color.R.ToString();
                string g = colorDialog1.Color.G.ToString();
                string b = colorDialog1.Color.B.ToString();
                if (r != null && g != null && b != null)
                {
                    cell.Style.BackColor = Color.FromArgb(int.Parse(r), int.Parse(g), int.Parse(b));
                    classDet.ChangeColor(r, g, b, e.RowIndex);
                }
            }
        }

        private void Bn_SaveClassResult_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "保存分类结果";
            saveFileDialog1.Filter = "栅格文件|*.tif";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_outputPath.Text = saveFileDialog1.FileName;
                RuleSetMessage.OutClassResultsPath = tb_outputPath.Text;
            }
        }

        private void bn_OK_Click(object sender, EventArgs e)
        {
            if (classDet.ReadRuleSet())
            {
                //classname = classDet.LoadClassInfo();               
                RuleSetMessage.OutClassResultsPath = tb_outputPath.Text;
                string outPath = classDet.SearchAlgoParams2();
                tb_outputPath.Text = ParseOutPathRe(outPath);
                string changedOutPath = ChangeOutPath(ref outPath, RuleSetMessage.OutClassResultsPath);
                classDet.ChangeoutPath2(changedOutPath);
                RuleSetMessage.AlgoOptions = 2;
            }
            else
            {
                MessageBox.Show("输入信息不完全，请重新设置！");
                return;
            }
            this.Close();
        }
        private string ParseOutPathRe(string inputXML)
        {
            string pattern = @"\bExportPath=""(\S+)""";
            Match m = Regex.Match(inputXML, pattern);
            return m.Groups[1].Value;
        }
        private string ChangeOutPath(ref string originalInfo, string inputPath)
        {
            string changedOutPath = string.Empty;
            string original = ParseOutPathRe(originalInfo);
            if (inputPath != string.Empty&&originalInfo!=string.Empty)
            {
                changedOutPath = originalInfo.Replace(original, inputPath);
            }
            return changedOutPath;
        }
    }
}
