using PIE.AxControls;
using PIE.Carto;
using PIE.Controls;
using PIE.Geometry;
using PIE.SystemUI;
using PIE.CommonAlgo;
using PIE.Framework;
using PIE.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalyseImageCshap;
using System.Threading;
using System.Windows.Forms;

namespace Sparkle
{
    public partial class MainForm : Form
    {

        #region 成员变量
        //this.axMapControl2 = new PIE.AxControls.MapControl();
        public static MainForm parentForm = null;
        /// <summary>
        /// 地图控件对象
        /// </summary>
        PIE.SystemUI.ITrackerCancel m_TrackerCancel = new PIE.SystemUI.TrackerCancel();
        //MapControl m_MapControl;

        /// <summary>
        /// TOC控件对象
        /// </summary>
        TOCControl m_TOCControl;
        public MapControl axMapControl2;

        //ProgressBar progressBar = new ProgressBar();
       
        //StatusBar m_StatusBar;
        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            // 添加MapControl,this.axMapControl2 = new PIE.AxControls.MapControl();
            axMapControl2 = new PIE.AxControls.MapControl();
            axMapControl2.ActiveView.TrackerCancel = m_TrackerCancel;
            //m_MapControl = new MapControl();
            axMapControl2.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(axMapControl2);
            axMapControl2.MouseMove += axMapControl2_MouseMove;
            axMapControl2.MouseClick += axMapControl2_MouseClick;
            //splitContainer1.Panel2.MouseClick+= axMapControl2_MouseClick;

            //axMapControl2.Click += axMapControl2_MouseClick;
            //IMap map = axMapControl2.FocusMap;

            // 添加TOCControl
            m_TOCControl = new TOCControl();
            m_TOCControl.SetBuddyControl(axMapControl2);
            m_TOCControl.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(m_TOCControl);
            m_TOCControl.MouseClick += m_TOCControl_MouseClick;
            
            //状态栏
            //m_StatusBar = statusStrip1 as IStatusBar;
            //m_StatusBar.Initial();
           
            // TOC按钮绑定
            //ActiveMap_MenuItem.Tag = new ActivateMapCommand();

            VectorLoader_MenuItem.Tag = new VectorLoaderMenuCommand();
            RasterLoader_MenuItem.Tag = new RasterLoaderMenuCommand();

            TurnOffAll_MenuItem.Tag = new TurnOffAllLayersCommand();
            TurnOffAllGroupLayer_MenuItem.Tag = new TurnOffAllLayersCommand();
            TurnOnAll_MenuItem.Tag = new TurnOnAllLayersCommand();
            TurnOnAllGroupLayer_MenuItem.Tag = new TurnOnAllLayersCommand();

            ClearAll_MenuItem.Tag = new ClearAllLayersCommand();
            ClearAllGroupLayer_MenuItem.Tag = new ClearAllLayersCommand();

            OpenFilePathFeatureLayer_MenuItem.Tag = new OpenFilePathCommand();
            OpenFilePathGroupLayer_MenuItem.Tag = new OpenFilePathCommand();
            OpenFilePathRasterLayer_MenuItem.Tag = new OpenFilePathCommand();

            DeleteFeatureLayer_MenuItem.Tag = new DeleteLayerCommand();
            DeleteRasterLayer_MenuItem.Tag = new DeleteLayerCommand();
            DeleteGroupLayer_MenuItem.Tag = new DeleteLayerCommand();

            ZoomtoFeatureLayer_MenuItem.Tag = new ZoomToLayerCommand();
            ZoomToGroupLayer_MenuItem.Tag = new ZoomToLayerCommand();
            ZoomTORasterLayer_MenuItem.Tag = new ZoomToLayerCommand();

            AnnotationFeatureLayer_MenuItem.Tag = new FeatureLayerAnnotationCommand();
            AttributeToolStripMenuItem.Tag = new FeatureLayerAttributeCommand();
            LayerAttributeMenuItem.Tag = new LayerPropertyCommand();
            ZoomInToolStripMenuItem.Tag = new MapZoomInTool();
            parentForm = this;
        }
        #endregion

        #region 控件事件
        private void axMapControl2_MouseClick(object sender,MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                contextMenuStrip_mapcontrol.Show(axMapControl2, new System.Drawing.Point(e.X, e.Y));
            }
        }
        /// <summary>
        /// TOC右键菜单显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_TOCControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PIETOCNodeType type = PIETOCNodeType.Null;
                IMap map = null;
                ILayer layer = null;
                Object unk = Type.Missing;
                Object data = Type.Missing;
                m_TOCControl.HitTest(e.X, e.Y, ref type, ref map, ref layer, ref unk, ref data);

                switch (type)
                {
                    case PIETOCNodeType.Map:
                        this.contextMenuStrip_Map.Show(m_TOCControl, new System.Drawing.Point(e.X, e.Y));
                        break;
                    case PIETOCNodeType.FeatureLayer:
                        this.contextMenuStrip_FeatureLayer.Show(m_TOCControl, new System.Drawing.Point(e.X, e.Y));
                        break;
                    case PIETOCNodeType.RasterLayer:
                        this.contextMenuStrip_RasterLayer.Show(m_TOCControl, new System.Drawing.Point(e.X, e.Y));
                        break;
                    case PIETOCNodeType.GroupLayer:
                        this.contextMenuStrip_GroupLayer.Show(m_TOCControl, new System.Drawing.Point(e.X, e.Y));
                        break;
                    case PIETOCNodeType.MultiLayer:
                        this.contextMenuStrip_GroupLayer.Show(m_TOCControl, new System.Drawing.Point(e.X, e.Y));
                        break;
                    case PIETOCNodeType.GraphicsLayer:
                        break;
                }
            }
        }

        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axMapControl2_MouseMove(object sender, MouseEventArgs e)
        {
            //IList<IMap> maps= axMapControl2.GetMaps();
            //if(maps!=null)
            txtBox_PiexlCoord.Text = string.Format("{0},{1}", e.X, e.Y);
            IPoint point = axMapControl2.ToMapPoint(e.X, e.Y);
            txtBox_GeoCoord.Text = string.Format("{0},{1}", point.X.ToString("0.0000"), point.Y.ToString("0.0000"));
            ISpatialReference spatialReference = axMapControl2.SpatialReference;
            if (spatialReference == null) return;
            //IList<IMap> maps=axMapControl2.GetMaps();
            //ILayer layer= axMapControl2.GetLayer(0);
            int layerCount = axMapControl2.FocusMap.LayerCount;
            if (layerCount!=0)
            {
                lbl_SpatialReference.Text = "坐标系：" + spatialReference.Name;
            }
            else
                lbl_SpatialReference.Text = "坐标系：";
        }

        #endregion

        #region TOC右键菜单命令

        /// <summary>
        /// 创建右键菜单命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuStrip_VisibleChanged(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = sender as ContextMenuStrip;
            if (contextMenuStrip == null) return;
            if (contextMenuStrip.Visible == false) return;

            int count = contextMenuStrip.Items.Count;
            ToolStripMenuItem item = null;
            ICommand command = null;
            for (int i = 0; i < count; i++)
            {
                item = contextMenuStrip.Items[i] as ToolStripMenuItem;
                if (item == null) continue;
                if (item.Tag == null) continue;

                command = item.Tag as ICommand;
                if (command == null) continue;
                command.OnCreate(axMapControl2);
                item.Checked = command.Checked;
                item.Text = command.Caption;
                item.Enabled = command.Enabled;
                item.Image = command.Image;
            }
        }

        /// <summary>
        /// TOCMenuItem点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TOCMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            ICommand command = item.Tag as ICommand;
            if (command == null) return;

            command.OnClick();
        }

        #endregion

        #region 按钮及工具

        /// <summary>
        /// 打开矢量数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_OpenVector_Click(object sender, EventArgs e)
        {
            ICommand command = new VectorCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 打开栅格数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_OpenRaster_Click(object sender, EventArgs e)
        {
            ICommand command = new RasterCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 打开科学数据集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_HDF_Click(object sender, EventArgs e)
        {
            ICommand command = new ScientificDatasetCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 拉框放大
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_ZoomIn_Click(object sender, EventArgs e)
        {
            ITool tool = new MapZoomInTool();
            ICommand command = tool as ICommand;
            command.OnCreate(axMapControl2);
            axMapControl2.CurrentTool = tool;
        }

        /// <summary>
        /// 拉框缩小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_ZoomOut_Click(object sender, EventArgs e)
        {
            ITool tool = new MapZoomOutTool();
            ICommand command = tool as ICommand;
            command.OnCreate(axMapControl2);
            axMapControl2.CurrentTool = tool;
        }

        /// <summary>
        /// 中心放大
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_CenterZoomIn_Click(object sender, EventArgs e)
        {
            ICommand command = new CenterZoomInCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 中心缩小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_CenterZoomOut_Click(object sender, EventArgs e)
        {
            ICommand command = new CenterZoomOutCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 漫游
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Pan_Click(object sender, EventArgs e)
        {
            ITool tool = new PanTool();
            ICommand command = tool as ICommand;
            command.OnCreate(axMapControl2);
            axMapControl2.CurrentTool = tool;
        }

        /// <summary>
        /// 全图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_FullExtent_Click(object sender, EventArgs e)
        {
            ICommand command = new FullExtentCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 1：1显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_OneVOne_Click(object sender, EventArgs e)
        {
            ICommand command = new ZoomToNativeCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 前一视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_PreviousExtent_Click(object sender, EventArgs e)
        {
            ICommand command = new ZoomToPreviousExtentCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 后一视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_NextExtent_Click(object sender, EventArgs e)
        {
            ICommand command = new ZoomToNextExtentCommand();
            command.OnCreate(axMapControl2);
            command.OnClick();
        }

        /// <summary>
        /// 卷帘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_SwiperLayer_Click(object sender, EventArgs e)
        {
            ITool tool = new SwipeLayerTool();
            ICommand command = tool as ICommand;
            command.OnCreate(axMapControl2);
            axMapControl2.CurrentTool = tool;
            command.OnClick();
        }

        /// <summary>
        /// 拉框放大测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_ZoomInDemo_Click(object sender, EventArgs e)
        {
            ITool tool = new MapZoomInTool();
            ICommand command = tool as ICommand;
            command.OnCreate(axMapControl2);
            axMapControl2.CurrentTool = tool;
        }

        /// <summary>
        /// 全图显示测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_FullExtentDemo_Click(object sender, EventArgs e)
        {
            ICommand cmd = new FullExtentCommand();
            cmd.OnCreate(axMapControl2);
            cmd.OnClick();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MyISODATA myISODATA = new MyISODATA();
            myISODATA.OnCreate(axMapControl2);
            myISODATA.OnClick();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            PCAfusion pCAfusion = new PCAfusion();
            pCAfusion.OnCreate(axMapControl2);
            pCAfusion.OnClick();
        }

        private void axMapControl2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AlgoProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            Neural neural = new Neural();
            neural.OnCreate(axMapControl2);
            neural.OnClick();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SegClassForm segClassForm = new SegClassForm();
            segClassForm.ShowDialog();
            if (RuleSetMessage.OutShpPath != null || RuleSetMessage.OutClassResultsPath != null)
            {
                if(RuleSetMessage.OutShpPath!=null)
                {
                    ILayer layer = LayerFactory.CreateDefaultLayer(RuleSetMessage.OutShpPath);
                    if (layer != null)
                    {
                        axMapControl2.FocusMap.AddLayer(layer);
                        axMapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                        RuleSetMessage.OutShpPath = null;
                    }
                }
                else 
                {
                    ILayer layer = LayerFactory.CreateDefaultLayer(RuleSetMessage.OutClassResultsPath);
                    if (layer != null)
                    {
                        axMapControl2.FocusMap.AddLayer(layer);
                        axMapControl2.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
                        RuleSetMessage.OutClassResultsPath = null;
                    }
                }
            }
            
        }

        private void toolStripButton_RasterIdentify_Click(object sender, EventArgs e)
        {
            ITool tool = new RasterIdentifyTool();
            ICommand command = tool as ICommand;
            command.OnCreate(axMapControl2);
            axMapControl2.CurrentTool = tool;
            command.OnClick();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            ICommand command = item.Tag as ICommand;
            if (command == null) return;

            command.OnClick();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string currentPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            //string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            string htmlPath = currentDirectory + "help_app\\index.html";
            System.Diagnostics.Process.Start(htmlPath);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Kmeans2 kMeans = new Kmeans2();
            kMeans.OnCreate(axMapControl2);
            kMeans.OnClick();
        }
    }
}
