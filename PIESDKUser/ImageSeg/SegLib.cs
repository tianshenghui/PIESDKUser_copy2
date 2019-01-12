using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace Sparkle
{
    public class SegLib
    {
        [DllImport("SampleAMIEngine.dll", EntryPoint = "?AnalyseImage@@YA_NPEBD00@Z")]
        public static extern bool AnalyseImageCsharp(string imagePath, string rulePath);
        //[DllImport("kernel32.dll")]
        //public static extern bool FreeConsole();
        //[DllImport("kernel32.dll")]
        //public static extern bool AllocConsole();
        //public SegLib(string myImage,string myRuleSet)
        //{
        //    this.image = myImage;
        //    this.RuleSet = myRuleSet;
        //}

        public static string image { get; set; }
        public static string RuleSet { get; set; }
    }

}
