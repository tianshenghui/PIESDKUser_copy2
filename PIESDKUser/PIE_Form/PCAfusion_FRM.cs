using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PIE.CommonAlgo;
using PIE.DataSource;
using System.Windows.Forms;

namespace Sparkle
{
    public partial class PCAfusion_FRM : Form
    {
        private static Pansharp_Exchange_Info PCAfusionParams = new Pansharp_Exchange_Info();
        public static Pansharp_Exchange_Info PCAfusionParam
        {
            get { return PCAfusionParams; }
            set { PCAfusionParams = value; }
        }
        int BandCount;
        public PCAfusion_FRM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lb_BandSetting1_Click(object sender, EventArgs e)
        {

        }

        private void Bn_InputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据：";
            openFileDialog.Filter = "Raster Files|*.tif;*.tiff;*.img";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            Tb_InputFile.Text = openFileDialog.FileName;
            PCAfusionParams.MssFilePath = openFileDialog.FileName;
            IRasterDataset rasterDataset = DatasetFactory.OpenRasterDataset(openFileDialog.FileName, OpenMode.Update) as IRasterDataset;
            Lbox_BandDisplay.Items.Clear();
            for (int i = 1; i <= rasterDataset.GetBandCount(); i++)
            {
                Lbox_BandDisplay.Items.Add("波段" + i.ToString());
            }
            BandCount = rasterDataset.GetBandCount();
        }

        private void Bn_InputFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据：";
            openFileDialog.Filter = "Raster Files|*.tif;*.tiff;*.img";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            Tb_InputFile1.Text = openFileDialog.FileName;
            PCAfusionParams.PanFilePath = openFileDialog.FileName;
            IRasterDataset rasterDataset = DatasetFactory.OpenRasterDataset(openFileDialog.FileName, OpenMode.Update) as IRasterDataset;
            Cb_BandSelect.Items.Clear();
            for(int i=1;i<=rasterDataset.GetBandCount();i++)
            {
                Cb_BandSelect.Items.Add("波段" + i.ToString());
            }
        }

        private void Cb_BandSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            PCAfusionParams.HighChannel = Cb_BandSelect.SelectedIndex;
        }

        private void Bn_OutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "输出文件";
            saveFileDialog.Filter = "GEOTIFF Files(*.tiff,*.tif)|*.tif,*.tiff|ERDAS IMG(*.img)|*.img|ENVI IMG(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            Tb_OutputFile.Text = saveFileDialog.FileName;
            PCAfusionParams.OutputFilePath=saveFileDialog.FileName;
        }

        private void Bn_Clear_Click(object sender, EventArgs e)
        {
            Lbox_BandDisplay.SelectedItems.Clear();
        }

        private void Bn_SelectAll_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i <Lbox_BandDisplay.Items.Count; i++)
            {
                Lbox_BandDisplay.SelectedIndex = i;
            }   
        }

        private void Lbox_BandDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tb_NumSelectedBand.Text = Lbox_BandDisplay.SelectedItems.Count.ToString();
        }

        private void Bn_OK_Click(object sender, EventArgs e)
        {
            IList<int> MultiBand = new List<int>();
            for (int i = 0; i < BandCount; i++)
            {
                if (Lbox_BandDisplay.GetSelected(i))
                    MultiBand.Add(i);
            }
            if (MultiBand.Count == 0 || MultiBand.Count == 1)
                MessageBox.Show("请至少选择两个波段，请检查！");
            else if (Tb_InputFile1.Text == "")
                MessageBox.Show("请加载高分辨率影像！");
            else if (Tb_OutputFile.Text == "")
                MessageBox.Show("请输入输出路径！");

            else
            {
                PCAfusionParams.MULChannels = MultiBand;
                PCAfusionParams.AlgoType = 0;
                PCAfusionParams.FileTypeCode = "GTiff";
                PCAfusionParams.BMultiThread = true;
                DialogResult = DialogResult.OK;
            }            
        }

        private void Cb_Resample_SelectedIndexChanged(object sender, EventArgs e)
        {
            PCAfusionParams.ResampleMode = Cb_Resample.SelectedIndex;
        }

        private void Bn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_BandSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
