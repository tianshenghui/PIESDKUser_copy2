using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PIE.Plugin;
using PIE.CommonAlgo;
using PIE.DataSource;
using PIE.Carto;
using PIE.Controls;
using PIE.SystemAlgo;
using PIE.Framework;
using AnalyseImageCshap;
namespace Sparkle
{
    public partial class ISODATA_FRM : Form
    {
        private static ISODataClassification_Exchange_Info iSODataParams = new ISODataClassification_Exchange_Info();
        
        public static ISODataClassification_Exchange_Info ISODataParams
        {
            get { return iSODataParams; }
            set { iSODataParams = value; }
        }     
        public ISODATA_FRM()
        {
            InitializeComponent();
        }
        int BandCount;
        private void Bn_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据：";
            openFileDialog.Filter = "Raster Files|*.tif;*.tiff;*.img";
            if (openFileDialog.ShowDialog() !=DialogResult.OK) return;
            Tb_InputFile.Text = openFileDialog.FileName;
            iSODataParams.InputFilePath = openFileDialog.FileName;
            IRasterDataset rasterDataset = DatasetFactory.OpenRasterDataset(openFileDialog.FileName, OpenMode.Update) as IRasterDataset;
            LB_BandDisplay.Items.Clear();
            for(int i=1;i<=rasterDataset.GetBandCount();i++)
            {
                LB_BandDisplay.Items.Add("波段" + i.ToString());
            }
            BandCount = rasterDataset.GetBandCount();
        }
        
        private void Bn_Excecute_Click(object sender, EventArgs e)
        {
            IList<int> lowBand = new List<int>();
            for (int i = 0; i < BandCount; i++)
            {
                if (LB_BandDisplay.GetSelected(i))
                    lowBand.Add(i);
            }
            if (lowBand.Count == 0)
                MessageBox.Show("请至少选择一个波段！");
            else if (Tb_OutputPath.Text == "")
                MessageBox.Show("请输入输出路径！");
            else
            {
                iSODataParams.LowBands = lowBand;
                ISODataParams.ProspClassNum = Convert.ToInt16(nud_PreCateNum.Value);
                iSODataParams.InitClassNum = Convert.ToInt16(nud_InitCateNum.Value);
                iSODataParams.MinSam = Convert.ToInt16(nud_MinPixelNum.Value);
                iSODataParams.MaxMerge = Convert.ToInt16(nud_MaxComCpNum.Value);
                iSODataParams.MaxLoop = Convert.ToInt16(nud_MaxIteraNum.Value);
                try
                {
                    iSODataParams.MinDis = Convert.ToDouble(Tb_MinCenDistance.Text);
                    iSODataParams.Dev = Convert.ToDouble(Tb_MaxSD.Text);
                }
                catch(Exception exp)
                {
                    MessageBox.Show("最大标准差和最小中心距离应为数字，请检查！");
                    return;
                }
                if(iSODataParams.MinDis<0||iSODataParams.Dev<0)
                {
                    MessageBox.Show("最大标准差和最小中心距离应为正数，请检查！");
                    return;
                }
                iSODataParams.FuncName = "ISODATA分类";
                iSODataParams.FileTypeCode = "GTiff";
                ISODataClassificationAlgo iSODataClassificationAlgo = new ISODataClassificationAlgo
                {
                    Params = iSODataParams
                };
                DialogResult = DialogResult.OK;
            }

        }

        private void Bn_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "输出文件";
            saveFileDialog.Filter = "GEOTIFF Files(*.tiff,*.tif)|*.tif,*.tiff|ERDAS IMG(*.img)|*.img|ENVI IMG(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            Tb_OutputPath.Text = saveFileDialog.FileName;
            iSODataParams.OutputFilePath = saveFileDialog.FileName;
        }

        private void LB_BandDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lb_BandNum.Text = LB_BandDisplay.SelectedItems.Count.ToString();
        }

        private void Bn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bn_ClearBand_Click(object sender, EventArgs e)
        {
            LB_BandDisplay.SelectedItems.Clear();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Tb_PreCateNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
