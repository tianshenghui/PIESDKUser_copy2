using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PIE.Plugin ;
using System.Windows.Forms;
using PIE.CommonAlgo;
using PIE.DataSource;

namespace PIESDKUser
{
    public partial class Neural_FRM : Form
    {
        private static  NeuralNetworkCluster_Exchange_Info neuralEx=new NeuralNetworkCluster_Exchange_Info ();
     public static NeuralNetworkCluster_Exchange_Info NeuralEx
     {
       get { return neuralEx; }
       set { neuralEx = value; }
      }
        int BandCount;
        public Neural_FRM()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击获取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的数据";
            openFileDialog.Filter = "Raster Files|*.tif;*.tiff;*.img";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            textBox1.Text = openFileDialog.FileName;
            neuralEx.InputFilePath = openFileDialog.FileName;
            IRasterDataset rasterDataset = DatasetFactory.OpenRasterDataset(openFileDialog.FileName, OpenMode.Update) as IRasterDataset;
            for (int i = 1; i <= rasterDataset.GetBandCount(); i++)
            {
                
                listBox1 .Items .Add ("波段"+i.ToString ());
            }
            BandCount = rasterDataset.GetBandCount();
        }

        /// <summary>
        /// 确定，用于传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            IList<int> lowBand = new List<int>();
            for (int i = 0; i < BandCount; i++)
            {
                if (listBox1.GetSelected(i))
                    lowBand.Add(i);
            }
            neuralEx.LowBands = lowBand;
            if(lowBand.Count<=1)
            {
                MessageBox.Show("请至少选择两个波段！");
            }
            else
            {
                neuralEx.ClassNum = Convert.ToInt16(numUD_ClassNum.Value);
                neuralEx.Traintimes = Convert.ToInt16(numUD_InteraNum.Value);
                neuralEx.Ispeed = Convert.ToInt16(numUD_Speed.Value);
                DialogResult = DialogResult.OK;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             //定义一个string 类型的变量
            //str = (string)comboBox1.SelectedItem;
            if((string)comboBox1.SelectedItem=="交互传播网络")
            {
                neuralEx.AlgType = 0;
                //str = "对";
            }else
                neuralEx.AlgType = 1;
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //窗口大小
            //str = (string)comboBox1.SelectedItem;
            if ((string)comboBox2.SelectedItem == "1*1")
            {
                neuralEx.Windowsize = 0;
                //str = "对";
            }
            else if((string)comboBox2.SelectedItem == "3*3")
            {
                neuralEx.Windowsize = 1;

            }
            else if ((string)comboBox2.SelectedItem == "5*5") 

                neuralEx.Windowsize = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {//输出保存
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "输出文件";
            saveFileDialog.Filter = "GEOTIFF Files(*.tiff,*.tif)|*.tif,*.tiff|ERDAS IMG(*.img)|*.img|ENVI IMG(*.img)|*.img";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            textBox2.Text = saveFileDialog.FileName;
            neuralEx.OutputFilePath = saveFileDialog.FileName;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "选中波段数量：" + listBox1.SelectedItems.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
        }

        private void Neural_FRM_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
