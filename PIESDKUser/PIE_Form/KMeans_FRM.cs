using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIE.CommonAlgo;
using PIE.DataSource;
namespace PIESDKUser
{
    public partial class Form_KMeans : Form
    {
        int BandCount;
        private static KmeansClassification_Exchange_Info KMeansParams = new KmeansClassification_Exchange_Info();
        public static KmeansClassification_Exchange_Info KMeansParam
        {
            get { return KMeansParams; }
            set { KMeansParams = value; }
        }
        public Form_KMeans()
        {
            InitializeComponent();
        }

        private void bn_OK_Click(object sender, EventArgs e)
        {
            IList<int> lowBand = new List<int>();
            for (int i = 0; i < BandCount; i++)
            {
                if (lb_BandChoose.GetSelected(i))
                    lowBand.Add(i);
            }
            if (lowBand.Count == 0)
                MessageBox.Show("请至少选择一个波段，请检查！");
            else if (tb_KillThres.Text == "")
                MessageBox.Show("请设置终止阈值！");
            else if (tb_outFile.Text == "")
                MessageBox.Show("请设置输出路径！");
            else
            {
                KMeansParams.LowBands = lowBand;
                KMeansParams.ClassNum = Convert.ToInt16(nud_ClassNums.Value);
                KMeansParams.Maxloop = Convert.ToInt16(nud_MaxIterNums.Value);
                KMeansParams.Threshold = Convert.ToDouble(tb_KillThres.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void bn_InputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据：";
            openFileDialog.Filter = "Raster Files|*.tif;*.tiff;*.img";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            tb_InputFile.Text = openFileDialog.FileName;
            KMeansParams.InputFilePath = openFileDialog.FileName;
            IRasterDataset rasterDataset = DatasetFactory.OpenRasterDataset(openFileDialog.FileName, OpenMode.Update) as IRasterDataset;
            lb_BandChoose.Items.Clear();
            for (int i = 1; i <= rasterDataset.GetBandCount(); i++)
            {
                lb_BandChoose.Items.Add("波段" + i.ToString());
            }
            BandCount = rasterDataset.GetBandCount();
        }

        private void bn_OutFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "输出文件";
            saveFileDialog.Filter = "GEOTIFF Files(*.tiff,*.tif)|*.tif,*.tiff|ERDAS IMG(*.img)|*.img|ENVI IMG(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            tb_outFile.Text = saveFileDialog.FileName;
            KMeansParams.OutputFilePath = saveFileDialog.FileName;
        }

        private void bn_ClearBand_Click(object sender, EventArgs e)
        {
            string bnText = bn_ClearBand.Text;
            switch (bnText)
            {
                case "全选":
                    for (int i = 0; i < lb_BandChoose.Items.Count; i++)
                    {
                        lb_BandChoose.SelectedIndex = i;
                    }
                    bn_ClearBand.Text = "清空";
                    break;
                case "清空":
                    lb_BandChoose.SelectedItems.Clear();
                    bn_ClearBand.Text = "全选";
                    break;
                default:
                    return;
            }
        
        }

        private void lb_BandChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_SelectedBandNum.Text = "选中波段数量： " + lb_BandChoose.SelectedItems.Count.ToString();
        }

        private void bn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
