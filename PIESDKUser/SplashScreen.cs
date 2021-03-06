﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparkle
{
    /// <summary> 
    /// 启动画面 
    /// </summary> 
    public partial class SplashScreen : Form
    {
        /// <summary> 
        /// 启动画面本身 
        /// </summary> 
        static SplashScreen instance;
        /// <summary> 
        /// 显示的图片 
        /// </summary> 
        Bitmap bitmap;
        public static SplashScreen Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public SplashScreen()
        {
            InitializeComponent();
            // 设置窗体的类型 
            const string ProgramName = "Sparkle遥感图像分类";
            const string showInfo = "启动画面：我们正在努力的加载程序，请稍后...";
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            ShowInTaskbar = false;
            bitmap = new Bitmap(Properties.Resources.SplashScreen);
            ClientSize = bitmap.Size;
            using(Font font = new Font("宋体", 30))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawString(ProgramName, font, Brushes.Black, 440, 200);
                }
            }
            using (Font font = new Font("Consoles", 15))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawString(showInfo, font, Brushes.Black, 400, 500);
                }
            }
            BackgroundImage = bitmap;
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing && (components != null))
            {
                if (bitmap != null)
                {
                    bitmap.Dispose();
                    bitmap = null;
                }
                components.Dispose();
            }
        }
        public static void ShowSplashScreen()
        {
            instance = new SplashScreen();
            instance.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
