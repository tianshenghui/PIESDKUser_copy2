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
namespace PIESDKUser
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
            //IList<int> lowBand = new List<int>();
            //for (int i = 0; i < rasterDataset.GetBandCount(); i++)
            //{
            //    if (LB_BandDisplay.GetSelected(i))
            //        lowBand.Add(i);
            //}
            //lowBand.Add(0);lowBand.Add(1);lowBand.Add(2);
            //iSODataParams.LowBands = lowBand;
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
            else
            {
                iSODataParams.LowBands = lowBand;
                iSODataParams.ProspClassNum = Convert.ToInt16(Tb_PreCateNum.Text);
                iSODataParams.InitClassNum = Convert.ToInt16(Tb_InitCateNum.Text);
                iSODataParams.MinSam = Convert.ToInt16(Tb_MinPixelNum.Text);
                iSODataParams.MaxMerge = Convert.ToInt16(Tb_MaxComCpNum.Text);
                iSODataParams.MaxLoop = Convert.ToInt16(Tb_MaxIteraNum.Text);
                iSODataParams.MinDis = Convert.ToDouble(Tb_MinCenDistance.Text);
                iSODataParams.Dev = Convert.ToDouble(Tb_MaxSD.Text);
                iSODataParams.FuncName = "ISODATA分类";
                iSODataParams.FileTypeCode = "GTiff";
                ISODataClassificationAlgo iSODataClassificationAlgo = new ISODataClassificationAlgo
                {
                    Params = iSODataParams
                };
                DialogResult = DialogResult.OK;
            }
            //ISystemAlgoEvents systemAlgoEvents = iSODataClassificationAlgo as ISystemAlgoEvents;
            //systemAlgoEvents.OnExecuteCompleted += OnAlgoExecuteCompleted;
            ////systemAlgoEvents.OnProgressChanged += OnAlgoProgresChanged;
            //System.Windows.Forms.Application.DoEvents();

            //iSODataClassificationAlgo.Execute();

            //AlgoFactory.Instance().AsynExecuteAlgo(iSODataClassificationAlgo);
            //Close();

        }

        private void Bn_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "输出文件";
            saveFileDialog.Filter = "GEOTIFF Files(*.tiff,*.tif)|*.tif,*.tiff|ERDAS IMG(*.img)|*.img|ENVI IMG(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            Tb_OutputPath.Text = saveFileDialog.FileName;
            iSODataParams.OutputFilePath = saveFileDialog.FileName;
            //易康dll测试
            //string imagePath = @"D:\EC\data.tif";
            //string rulePath = @"D:\EC\testvv.dcp";
            //int result = Class1.AnalyseImage(imagePath, rulePath);
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
        //private void OnAlgoExecuteCompleted(ISystemAlgo algo)
        //{
        //    //ISODataClassification_Exchange_Info exchange_Info = new ISODataClassification_Exchange_Info();
        //    //IRasterDataset rasterDataset = DatasetFactory.OpenRasterDataset(exchange_Info.OutputFilePath, OpenMode.ReadOnly) as IRasterDataset;
        //    //ILayer layer = LayerFactory.CreateDefaultRasterLayer(rasterDataset) as ILayer;
        //    ILayer layer = LayerFactory.CreateDefaultLayer(MyIODATA_FRM.ISODataParams.OutputFilePath);
        //    //IMap map = m_HookHelper.FocusMap;
        //    // map.AddLayer(layer);         
        //    Form1.axMapControl2.FocusMap.AddLayer(layer);
        //    Form1.axMapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        //    ISystemAlgoEvents algoEvents = algo as ISystemAlgoEvents;
        //    algoEvents.OnExecuteCompleted -= OnAlgoExecuteCompleted;
        //    algoEvents.OnProgressChanged -= OnAlgoProgresChanged;
        //}
        //private  int  OnAlgoProgresChanged(double complete, string msg, ISystemAlgo algo)
        //{

        //    Form1.AlgoProgressBar.Value = Convert.ToInt16(complete);
        //    Form1.AlgoStatusLabel.Text = msg;
        //    ISystemAlgoEvents algoEvents = algo as ISystemAlgoEvents;
        //    //algoEvents.OnExecuteCompleted += OnAlgoExecuteCompleted;
        //    //algoEvents.OnProgressChanged -= OnAlgoProgresChanged;
        //    return 0;
        //}
    }
}
