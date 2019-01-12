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
        public static string image { get; set; }
        public static string RuleSet { get; set; }
    }

}
