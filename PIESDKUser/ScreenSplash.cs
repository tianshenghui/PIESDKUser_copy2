using System;
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
    public partial class ScreenSplash : Control
    {
        static ScreenSplash instance;
        /// <summary> 
        /// 显示的图片 
        /// </summary> 
        public static ScreenSplash Instance
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
        public ScreenSplash()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            StringFormat style = new StringFormat();
            style.Alignment = StringAlignment.Near;
       
                    style.Alignment = StringAlignment.Center;
      

            // Call the DrawString method of the System.Drawing class to write   
            // text. Text and ClientRectangle are properties inherited from
            // Control.
            e.Graphics.DrawString(
                Text,
                Font,
                new SolidBrush(ForeColor),
                ClientRectangle, style);
        }

        public static void ShowSplashScreen()
        {
            instance = new ScreenSplash();
            instance.Show();
        }
    }
}
