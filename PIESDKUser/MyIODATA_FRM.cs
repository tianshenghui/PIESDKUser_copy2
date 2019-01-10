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
namespace PIESDKUser
{
    public partial class MyIODATA_FRM : Form
    {
        private static ISODataClassification_Exchange_Info iSODataParams = new ISODataClassification_Exchange_Info();
        public static ISODataClassification_Exchange_Info ISODataParams
        {
            get { return iSODataParams; }
            set { iSODataParams = value; }
        }     
        public MyIODATA_FRM()
        {
            InitializeComponent();
        }

        private void Bn_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据：";
            openFileDialog.Filter = "Raster Files|*.tif;*.tiff;*.img";
            if (openFileDialog.ShowDialog() !=DialogResult.OK) return;
            Tb_InputFile.Text = openFileDialog.FileName;
            iSODataParams.InputFilePath = openFileDialog.FileName;
            IRasterDataset rasterDataset = DatasetFactory.OpenRasterDataset(openFileDialog.FileName, OpenMode.Update) as IRasterDataset;
            for(int i=1;i<=rasterDataset.GetBandCount();i++)
            {
                LB_BandDisplay.Items.Add("波段" + i.ToString());
            }
            IList<int> lowBand = new List<int>();
            lowBand.Add(0);lowBand.Add(1);lowBand.Add(2);
            iSODataParams.LowBands = lowBand;

        }

        private void Bn_Excecute_Click(object sender, EventArgs e)
        {
            iSODataParams.ProspClassNum = Convert.ToInt16(Tb_PreCateNum.Text);
            iSODataParams.InitClassNum = Convert.ToInt16(Tb_InitCateNum.Text);
            iSODataParams.MinSam = Convert.ToInt16(Tb_MinPixelNum.Text);
            iSODataParams.MaxMerge = Convert.ToInt16(Tb_MaxComCpNum.Text);
            iSODataParams.MaxLoop = Convert.ToInt16(Tb_MaxIteraNum.Text);
            iSODataParams.MinDis = Convert.ToDouble(Tb_MinCenDistance.Text);
            iSODataParams.Dev = Convert.ToDouble(Tb_MaxSD.Text);
            iSODataParams.FuncName = "ISODATA分类";
            iSODataParams.FileTypeCode = "GTiff";
            //ISODataClassificationAlgo iSODataClassificationAlgo = new ISODataClassificationAlgo
            //{
            //    Params = iSODataParams
            //};
            //AlgoFactory.Instance().AsynExecuteAlgo(iSODataClassificationAlgo);
            //ISystemAlgoEvents systemAlgoEvents = iSODataClassificationAlgo as ISystemAlgoEvents;
            //systemAlgoEvents.OnExecuteCompleted += OnAlgoExecuteCompleted;
            DialogResult = DialogResult.OK;
        }

        private void Bn_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "输出文件";
            saveFileDialog.Filter = "GEOTIFF Files(*.tiff,*.tif)|*.tif,*.tiff";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            Tb_OutputPath.Text = saveFileDialog.FileName;
            iSODataParams.OutputFilePath = saveFileDialog.FileName;
        }
        
    }
}
