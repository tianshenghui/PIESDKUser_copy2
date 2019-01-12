using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sparkle
{
    
    public class XmlInfo
    {
        //根据名字ID找寻节点
        public string[] Nd_Name { get; set; }
        public string XmlPath { get; set; }
        public XmlDocument RuleSet { get; set; }
        public XmlElement Element { get; set; }
        public string[] SearchParams { get; set; }
        /// <summary>
        /// 要修改的xml文件路径，并且输入分割尺度、形状因子、紧致度因子的Name属性
        /// </summary>
        /// <param name="xmlPath">xml路径</param>
        /// <param name="names">分割参数</param>
        public XmlInfo(string xmlPath, params string[] names)
        {
            this.XmlPath = xmlPath;
            this.Nd_Name = names;
        }
        public bool ReadRuleSet()
        {
            if (File.Exists(XmlPath))
            {
                using (FileStream stream = File.OpenRead(XmlPath))
                {
                    RuleSet = new XmlDocument();
                    RuleSet.Load(stream);
                }
            }
            else
                return false;
            return true;
        }
        //用于搜索导出矢量文件的路径
        public string SearchAlgoParams()
        {

            
                XmlNodeList nodes = RuleSet.SelectNodes("/eCog.Proc/ProcessList/ProcBase");
                XmlNodeList ProcessParams;
                string outPath=string.Empty;
                //XmlNodeList OutPathParams;
                for (int i = 0; i<nodes.Count;i++)
                {
                    //XmlNodeList ProcessNode = nodes.Item(i).SelectNodes("Algorithm");

                    foreach (XmlElement node in nodes.Item(i))
                    {
                        if (node.GetAttribute("guid") == "E8AAA2C4-4DCA-4684-A918-87E7C53CDC8D")
                        {
                            ProcessParams = nodes.Item(i).SelectNodes("Algorithm/Params/DValue");
                            foreach(XmlElement node1 in ProcessParams)
                            {
                                if (node1.GetAttribute("name") == "strExportItemInfo")
                                    outPath = node1.GetAttribute("value");
                            }
                        }
                        //return string.Empty;
                    }
                }
            return outPath;
            
        }
        //用于搜索导出分类结果的路径
        public string SearchAlgoParams2()
        {


            XmlNodeList nodes = RuleSet.SelectNodes("/eCog.Proc/ProcessList/ProcBase");
            XmlNodeList ProcessParams;
            string outPath = string.Empty;
            //XmlNodeList OutPathParams;
            for (int i = 0; i < nodes.Count; i++)
            {
                //XmlNodeList ProcessNode = nodes.Item(i).SelectNodes("Algorithm");

                foreach (XmlElement node in nodes.Item(i))
                {
                    if (node.GetAttribute("guid") == "F2834958-45AA-42f4-908A-3323CA7E3C43")
                    {
                        ProcessParams = nodes.Item(i).SelectNodes("Algorithm/Params/DValue");
                        foreach (XmlElement node1 in ProcessParams)
                        {
                            if (node1.GetAttribute("name") == "strExportItemInfo")
                                outPath = node1.GetAttribute("value");
                        }
                    }
                    //return string.Empty;
                }
            }
            return outPath;

        }
        public string[] SearchNdVal()
        {
            string[] searchResults = { "0", "0", "0" };
            string scale, shape, compactness,outpath;
            if (this.Nd_Name != null)
            {
                //得到所有的DValue节点
                XmlNodeList nodes = RuleSet.SelectNodes("/eCog.Proc/ProcessList/ProcBase/Algorithm/Params/DValue");
                foreach (XmlElement node in nodes)
                {
                    foreach (string name in this.Nd_Name)
                    {
                        if (node.GetAttribute("name").ToString() == name)
                        {
                            switch (name)
                            {
                                case "vrblValScale":
                                    scale=node.GetAttribute("value");
                                    searchResults[0] = scale;
                                    break;
                                case "vrblHCShape":
                                    shape=node.GetAttribute("value");
                                    searchResults[1] = shape;
                                    break;
                                case "vrblHCArea":
                                    compactness=node.GetAttribute("value");
                                    searchResults[2] = compactness;
                                    break;
                                case "strExportPath":
                                    outpath = node.GetAttribute("value");
                                    searchResults[3] = outpath;
                                    break;
                            }
                        }
                    }
                }
               
                //DisplayedParams = new Dictionary<string, string>(3)
                //{

                //};
            }

            return searchResults;
        }
        /// <summary>
        /// 找出相应的节点并改变其值
        /// </summary>
        /// <param name="scale">多尺度分割尺度</param>
        /// <param name="shape">形状因子</param>
        /// <param name="compactness">紧致度因子</param>
        //
        public void ChangeNdVal(string scale, string shape, string compactness)
        {
            //XmlDocument doc = new XmlDocument();
            //XmlElement root;

            ////判断读取文件是否存在
            //if (File.Exists(XmlPath))
            //{
            //    doc.Load(XmlPath);
            //    root = doc.DocumentElement;
            //}
            //else
            //{
            //    return;
            //}
                if (this.Nd_Name != null)
                {
                    //得到所有的DValue节点
                    XmlNodeList nodes = RuleSet.SelectNodes("/eCog.Proc/ProcessList/ProcBase/Algorithm/Params/DValue");
                    foreach (XmlElement node in nodes)
                    {
                        foreach (string name in this.Nd_Name)
                        {
                            if (node.GetAttribute("name").ToString() == name)
                            {
                                switch (name)
                                {
                                    case "vrblValScale":
                                        node.SetAttribute("value", scale);
                                        break;
                                    case "vrblHCShape":
                                        node.SetAttribute("value", shape);
                                        break;
                                    case "vrblHCArea":
                                        node.SetAttribute("value", compactness);
                                        break;

                                }
                            }
                        }
                    }
                    RuleSet.Save(this.XmlPath);
                }
            
            else return;


        }
        public bool ChangeoutPath(string updateInfo)
        {
            XmlNodeList nodes = RuleSet.SelectNodes("/eCog.Proc/ProcessList/ProcBase");
            XmlNodeList ProcessParams;
            string outPath = string.Empty;
            //XmlNodeList OutPathParams;
            for (int i = 0; i < nodes.Count; i++)
            {
                //XmlNodeList ProcessNode = nodes.Item(i).SelectNodes("Algorithm");

                foreach (XmlElement node in nodes.Item(i))
                {
                    if (node.GetAttribute("guid") == "E8AAA2C4-4DCA-4684-A918-87E7C53CDC8D")
                    {
                        ProcessParams = nodes.Item(i).SelectNodes("Algorithm/Params/DValue");
                        foreach (XmlElement node1 in ProcessParams)
                        {
                            if (node1.GetAttribute("name") == "strExportItemInfo")
                            {
                                node1.SetAttribute("value", updateInfo);
                                RuleSet.Save(this.XmlPath);
                                return true;
                            }

                        }
                    }
                    //return string.Empty;
                }
            }
            return false;
        }
        public bool ChangeoutPath2(string updateInfo)
        {
            XmlNodeList nodes = RuleSet.SelectNodes("/eCog.Proc/ProcessList/ProcBase");
            XmlNodeList ProcessParams;
            string outPath = string.Empty;
            //XmlNodeList OutPathParams;
            for (int i = 0; i < nodes.Count; i++)
            {
                //XmlNodeList ProcessNode = nodes.Item(i).SelectNodes("Algorithm");

                foreach (XmlElement node in nodes.Item(i))
                {
                    if (node.GetAttribute("guid") == "F2834958-45AA-42f4-908A-3323CA7E3C43")
                    {
                        ProcessParams = nodes.Item(i).SelectNodes("Algorithm/Params/DValue");
                        foreach (XmlElement node1 in ProcessParams)
                        {
                            if (node1.GetAttribute("name") == "strExportItemInfo")
                            {
                                node1.SetAttribute("value", updateInfo);
                                RuleSet.Save(this.XmlPath);
                                return true;
                            }

                        }
                    }
                    //return string.Empty;
                }
            }
            return false;
        }
        public List<string> LoadClassInfo()
        {
            //XmlDocument doc = new XmlDocument();
            //XmlElement root;

            //if (File.Exists("final.dcp"))
            //{
            //    doc.Load("final.dcp");
            //    root = doc.DocumentElement;
            //}
            //else
            //{
            //    return null;
            //}
            List<string> className = new List<string>();
            XmlNodeList classNode = RuleSet.SelectNodes("/eCog.Proc/ObjectDependencies/ClssHrchy/AllClss/Clss");
            foreach (XmlElement node in classNode)
            {
                //存储类名
                string name = node.GetAttribute("name").ToString();
                className.Add(name);
                name = null;
                //XmlNodeList nodeColors = node.SelectNodes("/Color");

            }
            return className;
        }
        public void ChangeColor(string red, string green, string blue, int index)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("final.dcp");
            XmlNodeList colorNodes = RuleSet.SelectNodes("/eCog.Proc/ObjectDependencies/ClssHrchy/AllClss/Clss/Color");
            XmlElement color = (XmlElement)colorNodes[index];

            color.SetAttribute("R", red);
            color.SetAttribute("G", green);
            color.SetAttribute("B", blue);


            RuleSet.Save(this.XmlPath);

        }
        public List<Tuple<byte, byte, byte>> ObtainClassColor()
        {
            List<Tuple<byte, byte, byte>> AllClassColor = new List<Tuple<byte, byte, byte>>();
            Tuple<byte, byte, byte> ColorTuple;
            XmlNodeList colorNodes = RuleSet.SelectNodes("/eCog.Proc/ObjectDependencies/ClssHrchy/AllClss/Clss/Color");
            for(int i=0;i<colorNodes.Count;i++)
            {
                XmlElement color= (XmlElement)colorNodes[i];
                byte.TryParse(color.GetAttribute("R"), out byte R);
                byte.TryParse(color.GetAttribute("G"), out byte G);
                byte.TryParse(color.GetAttribute("B"), out byte B);
                ColorTuple= Tuple.Create(R, G, B);
                AllClassColor.Add(ColorTuple);
            }
            return AllClassColor;
        }
    }
}
