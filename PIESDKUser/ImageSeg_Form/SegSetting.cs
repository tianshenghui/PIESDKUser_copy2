using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace PIESDKUser
{
    public partial class SegSetting: Form
    {        
        public SegSetting()
        {
    
            InitializeComponent();
            //if (RuleSetMessage.RuleSetPath!=null)
            //{
            //    XmlInfo xml_doc = new XmlInfo(RuleSetMessage.RuleSetPath, "vrblValScale", "vrblHCShape", "vrblHCArea");
            //    xml_doc.ReadRuleSet();
            //    xml_doc.displayNdVal();
            //}
            //else
            //    return;
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            XmlInfo xml_doc = new XmlInfo(RuleSetMessage.RuleSetPath, "vrblValScale", "vrblHCShape", "vrblHCArea");
            xml_doc.ReadRuleSet();
            string scale = this.txt_scale.Text;
            string shape = this.txt_shape.Text;
            string comp =this.txt_compactness.Text;
            string outpath = tb_outpath.Text;
            float scalevalue, shapevalue, compvalue;
            bool validate1=float.TryParse(scale,out scalevalue);
            bool validate2=float.TryParse(shape, out shapevalue);
            bool validate3=float.TryParse(comp, out compvalue);
            if (xml_doc.ReadRuleSet())
            {
                if (validate1 && validate2 && validate3 && (shapevalue >= 0.0 && shapevalue <= 0.9) && (compvalue >= 0 && compvalue <= 1.0))
                {
                    xml_doc.ChangeNdVal(scale, shape, comp);
                }
                else
                {
                    MessageBox.Show("请输入合法的参数值，Shape的范围在0-0.9之间，Compactness的范围在0-1之间");
                }
                string OutPathInfo = xml_doc.SearchAlgoParams();
                string changedOutPath = ChangeOutPath(ref OutPathInfo, outpath);
                xml_doc.ChangeoutPath(changedOutPath);
                RuleSetMessage.AlgoOptions = 0;
            }
            else
            {
                MessageBox.Show("输入信息不完全，请重新设置！");
                return;
            }
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bn_SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "保存分割后的矢量文件";
            saveFileDialog1.Filter = "SHP文件|*.shp";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                tb_outpath.Text = saveFileDialog1.FileName;
            }
        }

        private void Bn_DisplayIntialParams_Click(object sender, EventArgs e)
        {

            if (RuleSetMessage.RuleSetPath != null)
            {
                XmlInfo xml_doc = new XmlInfo(RuleSetMessage.RuleSetPath, "vrblValScale", "vrblHCShape", "vrblHCArea");
                xml_doc.ReadRuleSet();
                string[] searchedItems=xml_doc.SearchNdVal();
                txt_scale.Text = searchedItems[0];
                txt_shape.Text = searchedItems[1];
                txt_compactness.Text = searchedItems[2];
                //tb_outpath.Text = xml_doc.SearchAlgoParams();
                //txt_scale.Text = xml_doc.DisplayedParams[0];
                string OutPathInfo = xml_doc.SearchAlgoParams();
                tb_outpath.Text = ParseOutPathRe(OutPathInfo);
                RuleSetMessage.OutShpPath = tb_outpath.Text;
                //ParseOutXML(tb_outpath.Text);
            }
            else
                return;
        }
        private string  ParseOutXML(string inputXML)
        {
            XmlDocument xml = new XmlDocument();
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xml.NameTable);
            xml.Load(inputXML);
            XmlNode xmlNode = xml.DocumentElement.SelectSingleNode("ExportInfo");
            XmlElement xmlElement = (XmlElement)xmlNode;
            return xmlElement.GetAttribute("ExportPath");
        }
        private string ParseOutPathRe(string inputXML)
        {
            string pattern = @"\bExportPath=""(\S+)""";
            Match m = Regex.Match(inputXML, pattern);
            return m.Groups[1].Value;
        }
        private string ChangeOutPath(ref string originalInfo,string inputPath)
        {
            string original= ParseOutPathRe(originalInfo);
            string changedOutPath=originalInfo.Replace(original, inputPath);
            return changedOutPath;
        }
    }
}
