namespace PIESDKUser
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_OpenVector = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_OpenRaster = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_HDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CenterZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CenterZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Pan = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_FullExtent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_OneVOne = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_PreviousExtent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_NextExtent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SwiperLayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_ZoomInDemo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_FullExtentDemo = new System.Windows.Forms.ToolStripButton();
            this.ISODATA = new System.Windows.Forms.ToolStripButton();
            this.testButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axMapControl2 = new PIE.AxControls.MapControl();
            this.contextMenuStrip_Map = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActiveMap_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.VectorLoader_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RasterLoader_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TurnOnAll_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnOffAll_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAll_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_FeatureLayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteFeatureLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomtoFeatureLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenFilePathFeatureLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.AnnotationFeatureLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_RasterLayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteRasterLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomTORasterLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenFilePathRasterLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_GroupLayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteGroupLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomToGroupLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.TurnOnAllGroupLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnOffAllGroupLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllGroupLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenFilePathGroupLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_SpatialReference = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_GeoCoord = new System.Windows.Forms.TextBox();
            this.txtBox_PiexlCoord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip_Map.SuspendLayout();
            this.contextMenuStrip_FeatureLayer.SuspendLayout();
            this.contextMenuStrip_RasterLayer.SuspendLayout();
            this.contextMenuStrip_GroupLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1716, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "系统";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.新建ToolStripMenuItem.Text = "退出";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 938);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1716, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_OpenVector,
            this.toolStripButton_OpenRaster,
            this.toolStripButton_HDF,
            this.toolStripSeparator1,
            this.toolStripButton_ZoomIn,
            this.toolStripButton_ZoomOut,
            this.toolStripButton_CenterZoomIn,
            this.toolStripButton_CenterZoomOut,
            this.toolStripButton_Pan,
            this.toolStripButton_FullExtent,
            this.toolStripButton_OneVOne,
            this.toolStripButton_PreviousExtent,
            this.toolStripButton_NextExtent,
            this.toolStripButton_SwiperLayer,
            this.toolStripSeparator2,
            this.toolStripButton_ZoomInDemo,
            this.toolStripButton_FullExtentDemo,
            this.ISODATA,
            this.testButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1716, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "常用功能";
            // 
            // toolStripButton_OpenVector
            // 
            this.toolStripButton_OpenVector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_OpenVector.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_OpenVector.Image")));
            this.toolStripButton_OpenVector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_OpenVector.Name = "toolStripButton_OpenVector";
            this.toolStripButton_OpenVector.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_OpenVector.Text = "打开矢量数据";
            this.toolStripButton_OpenVector.Click += new System.EventHandler(this.toolStripButton_OpenVector_Click);
            // 
            // toolStripButton_OpenRaster
            // 
            this.toolStripButton_OpenRaster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_OpenRaster.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_OpenRaster.Image")));
            this.toolStripButton_OpenRaster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_OpenRaster.Name = "toolStripButton_OpenRaster";
            this.toolStripButton_OpenRaster.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_OpenRaster.Text = "打开栅格数据";
            this.toolStripButton_OpenRaster.Click += new System.EventHandler(this.toolStripButton_OpenRaster_Click);
            // 
            // toolStripButton_HDF
            // 
            this.toolStripButton_HDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_HDF.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_HDF.Image")));
            this.toolStripButton_HDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_HDF.Name = "toolStripButton_HDF";
            this.toolStripButton_HDF.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_HDF.Text = "打开科学数据集";
            this.toolStripButton_HDF.Click += new System.EventHandler(this.toolStripButton_HDF_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton_ZoomIn
            // 
            this.toolStripButton_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ZoomIn.Image")));
            this.toolStripButton_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ZoomIn.Name = "toolStripButton_ZoomIn";
            this.toolStripButton_ZoomIn.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_ZoomIn.Text = "拉框放大";
            this.toolStripButton_ZoomIn.Click += new System.EventHandler(this.toolStripButton_ZoomIn_Click);
            // 
            // toolStripButton_ZoomOut
            // 
            this.toolStripButton_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ZoomOut.Image")));
            this.toolStripButton_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ZoomOut.Name = "toolStripButton_ZoomOut";
            this.toolStripButton_ZoomOut.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_ZoomOut.Text = "拉框缩小";
            this.toolStripButton_ZoomOut.Click += new System.EventHandler(this.toolStripButton_ZoomOut_Click);
            // 
            // toolStripButton_CenterZoomIn
            // 
            this.toolStripButton_CenterZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_CenterZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CenterZoomIn.Image")));
            this.toolStripButton_CenterZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CenterZoomIn.Name = "toolStripButton_CenterZoomIn";
            this.toolStripButton_CenterZoomIn.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_CenterZoomIn.Text = "中心放大";
            this.toolStripButton_CenterZoomIn.Click += new System.EventHandler(this.toolStripButton_CenterZoomIn_Click);
            // 
            // toolStripButton_CenterZoomOut
            // 
            this.toolStripButton_CenterZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_CenterZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CenterZoomOut.Image")));
            this.toolStripButton_CenterZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CenterZoomOut.Name = "toolStripButton_CenterZoomOut";
            this.toolStripButton_CenterZoomOut.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_CenterZoomOut.Text = "中心缩小";
            this.toolStripButton_CenterZoomOut.Click += new System.EventHandler(this.toolStripButton_CenterZoomOut_Click);
            // 
            // toolStripButton_Pan
            // 
            this.toolStripButton_Pan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Pan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Pan.Image")));
            this.toolStripButton_Pan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Pan.Name = "toolStripButton_Pan";
            this.toolStripButton_Pan.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_Pan.Text = "漫游";
            this.toolStripButton_Pan.Click += new System.EventHandler(this.toolStripButton_Pan_Click);
            // 
            // toolStripButton_FullExtent
            // 
            this.toolStripButton_FullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_FullExtent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_FullExtent.Image")));
            this.toolStripButton_FullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_FullExtent.Name = "toolStripButton_FullExtent";
            this.toolStripButton_FullExtent.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_FullExtent.Text = "全图显示";
            this.toolStripButton_FullExtent.Click += new System.EventHandler(this.toolStripButton_FullExtent_Click);
            // 
            // toolStripButton_OneVOne
            // 
            this.toolStripButton_OneVOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_OneVOne.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_OneVOne.Image")));
            this.toolStripButton_OneVOne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_OneVOne.Name = "toolStripButton_OneVOne";
            this.toolStripButton_OneVOne.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_OneVOne.Text = "1:1缩放";
            this.toolStripButton_OneVOne.Click += new System.EventHandler(this.toolStripButton_OneVOne_Click);
            // 
            // toolStripButton_PreviousExtent
            // 
            this.toolStripButton_PreviousExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_PreviousExtent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PreviousExtent.Image")));
            this.toolStripButton_PreviousExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PreviousExtent.Name = "toolStripButton_PreviousExtent";
            this.toolStripButton_PreviousExtent.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_PreviousExtent.Text = "前一视图";
            this.toolStripButton_PreviousExtent.Click += new System.EventHandler(this.toolStripButton_PreviousExtent_Click);
            // 
            // toolStripButton_NextExtent
            // 
            this.toolStripButton_NextExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_NextExtent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_NextExtent.Image")));
            this.toolStripButton_NextExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_NextExtent.Name = "toolStripButton_NextExtent";
            this.toolStripButton_NextExtent.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_NextExtent.Text = "后一视图";
            this.toolStripButton_NextExtent.Click += new System.EventHandler(this.toolStripButton_NextExtent_Click);
            // 
            // toolStripButton_SwiperLayer
            // 
            this.toolStripButton_SwiperLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_SwiperLayer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SwiperLayer.Image")));
            this.toolStripButton_SwiperLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SwiperLayer.Name = "toolStripButton_SwiperLayer";
            this.toolStripButton_SwiperLayer.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_SwiperLayer.Text = "卷帘";
            this.toolStripButton_SwiperLayer.Click += new System.EventHandler(this.toolStripButton_SwiperLayer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton_ZoomInDemo
            // 
            this.toolStripButton_ZoomInDemo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ZoomInDemo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ZoomInDemo.Image")));
            this.toolStripButton_ZoomInDemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ZoomInDemo.Name = "toolStripButton_ZoomInDemo";
            this.toolStripButton_ZoomInDemo.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_ZoomInDemo.Text = "拉框放大";
            this.toolStripButton_ZoomInDemo.Click += new System.EventHandler(this.toolStripButton_ZoomInDemo_Click);
            // 
            // toolStripButton_FullExtentDemo
            // 
            this.toolStripButton_FullExtentDemo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_FullExtentDemo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_FullExtentDemo.Image")));
            this.toolStripButton_FullExtentDemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_FullExtentDemo.Name = "toolStripButton_FullExtentDemo";
            this.toolStripButton_FullExtentDemo.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_FullExtentDemo.Text = "全图显示";
            this.toolStripButton_FullExtentDemo.Click += new System.EventHandler(this.toolStripButton_FullExtentDemo_Click);
            // 
            // ISODATA
            // 
            this.ISODATA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ISODATA.Image = ((System.Drawing.Image)(resources.GetObject("ISODATA.Image")));
            this.ISODATA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ISODATA.Name = "ISODATA";
            this.ISODATA.Size = new System.Drawing.Size(28, 28);
            this.ISODATA.Text = "ISODATA分类";
            this.ISODATA.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // testButton
            // 
            this.testButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testButton.Image = ((System.Drawing.Image)(resources.GetObject("testButton.Image")));
            this.testButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(28, 28);
            this.testButton.Text = "toolStripButton1";
            this.testButton.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMapControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1716, 873);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 7;
            // 
            // axMapControl2
            // 
            this.axMapControl2.BackColor = System.Drawing.Color.White;
            this.axMapControl2.CustomerProperty = null;
            this.axMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl2.Location = new System.Drawing.Point(0, 0);
            this.axMapControl2.Margin = new System.Windows.Forms.Padding(4);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.Size = new System.Drawing.Size(1370, 873);
            this.axMapControl2.TabIndex = 0;
            this.axMapControl2.Text = "mapControl1";
            this.axMapControl2.Click += new System.EventHandler(this.axMapControl2_Click);
            // 
            // contextMenuStrip_Map
            // 
            this.contextMenuStrip_Map.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_Map.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActiveMap_MenuItem,
            this.toolStripSeparator4,
            this.VectorLoader_MenuItem,
            this.RasterLoader_MenuItem,
            this.toolStripSeparator5,
            this.TurnOnAll_MenuItem,
            this.TurnOffAll_MenuItem,
            this.ClearAll_MenuItem});
            this.contextMenuStrip_Map.Name = "map_MenuStrip1";
            this.contextMenuStrip_Map.Size = new System.Drawing.Size(189, 184);
            this.contextMenuStrip_Map.VisibleChanged += new System.EventHandler(this.ContextMenuStrip_VisibleChanged);
            // 
            // ActiveMap_MenuItem
            // 
            this.ActiveMap_MenuItem.Name = "ActiveMap_MenuItem";
            this.ActiveMap_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.ActiveMap_MenuItem.Tag = "";
            this.ActiveMap_MenuItem.Text = "激活地图";
            this.ActiveMap_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(185, 6);
            // 
            // VectorLoader_MenuItem
            // 
            this.VectorLoader_MenuItem.Name = "VectorLoader_MenuItem";
            this.VectorLoader_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.VectorLoader_MenuItem.Text = "加载矢量数据";
            this.VectorLoader_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // RasterLoader_MenuItem
            // 
            this.RasterLoader_MenuItem.Name = "RasterLoader_MenuItem";
            this.RasterLoader_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.RasterLoader_MenuItem.Text = "加载栅格数据";
            this.RasterLoader_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(185, 6);
            this.toolStripSeparator5.VisibleChanged += new System.EventHandler(this.ContextMenuStrip_VisibleChanged);
            // 
            // TurnOnAll_MenuItem
            // 
            this.TurnOnAll_MenuItem.Name = "TurnOnAll_MenuItem";
            this.TurnOnAll_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.TurnOnAll_MenuItem.Text = "显示所有图层";
            this.TurnOnAll_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // TurnOffAll_MenuItem
            // 
            this.TurnOffAll_MenuItem.Name = "TurnOffAll_MenuItem";
            this.TurnOffAll_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.TurnOffAll_MenuItem.Text = "隐藏所有图层";
            this.TurnOffAll_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // ClearAll_MenuItem
            // 
            this.ClearAll_MenuItem.Name = "ClearAll_MenuItem";
            this.ClearAll_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.ClearAll_MenuItem.Text = "清除所有图层";
            this.ClearAll_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // contextMenuStrip_FeatureLayer
            // 
            this.contextMenuStrip_FeatureLayer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_FeatureLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteFeatureLayer_MenuItem,
            this.ZoomtoFeatureLayer_MenuItem,
            this.toolStripSeparator6,
            this.OpenFilePathFeatureLayer_MenuItem,
            this.toolStripSeparator7,
            this.AnnotationFeatureLayer_MenuItem,
            this.AttributeToolStripMenuItem});
            this.contextMenuStrip_FeatureLayer.Name = "feaLayer_MenuStrip2";
            this.contextMenuStrip_FeatureLayer.Size = new System.Drawing.Size(189, 156);
            this.contextMenuStrip_FeatureLayer.VisibleChanged += new System.EventHandler(this.ContextMenuStrip_VisibleChanged);
            // 
            // DeleteFeatureLayer_MenuItem
            // 
            this.DeleteFeatureLayer_MenuItem.Name = "DeleteFeatureLayer_MenuItem";
            this.DeleteFeatureLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.DeleteFeatureLayer_MenuItem.Text = "删除图层";
            this.DeleteFeatureLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // ZoomtoFeatureLayer_MenuItem
            // 
            this.ZoomtoFeatureLayer_MenuItem.Name = "ZoomtoFeatureLayer_MenuItem";
            this.ZoomtoFeatureLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.ZoomtoFeatureLayer_MenuItem.Text = "缩放到图层";
            this.ZoomtoFeatureLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(185, 6);
            // 
            // OpenFilePathFeatureLayer_MenuItem
            // 
            this.OpenFilePathFeatureLayer_MenuItem.Name = "OpenFilePathFeatureLayer_MenuItem";
            this.OpenFilePathFeatureLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.OpenFilePathFeatureLayer_MenuItem.Text = "打开文件位置";
            this.OpenFilePathFeatureLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(185, 6);
            // 
            // AnnotationFeatureLayer_MenuItem
            // 
            this.AnnotationFeatureLayer_MenuItem.Name = "AnnotationFeatureLayer_MenuItem";
            this.AnnotationFeatureLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.AnnotationFeatureLayer_MenuItem.Text = "标注要素";
            this.AnnotationFeatureLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // AttributeToolStripMenuItem
            // 
            this.AttributeToolStripMenuItem.Name = "AttributeToolStripMenuItem";
            this.AttributeToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.AttributeToolStripMenuItem.Text = "属性表";
            this.AttributeToolStripMenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // contextMenuStrip_RasterLayer
            // 
            this.contextMenuStrip_RasterLayer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_RasterLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteRasterLayer_MenuItem,
            this.ZoomTORasterLayer_MenuItem,
            this.toolStripSeparator9,
            this.OpenFilePathRasterLayer_MenuItem});
            this.contextMenuStrip_RasterLayer.Name = "contextMenuStrip_RasterLayer";
            this.contextMenuStrip_RasterLayer.Size = new System.Drawing.Size(189, 94);
            this.contextMenuStrip_RasterLayer.VisibleChanged += new System.EventHandler(this.ContextMenuStrip_VisibleChanged);
            // 
            // DeleteRasterLayer_MenuItem
            // 
            this.DeleteRasterLayer_MenuItem.Name = "DeleteRasterLayer_MenuItem";
            this.DeleteRasterLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.DeleteRasterLayer_MenuItem.Text = "删除图层";
            this.DeleteRasterLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // ZoomTORasterLayer_MenuItem
            // 
            this.ZoomTORasterLayer_MenuItem.Name = "ZoomTORasterLayer_MenuItem";
            this.ZoomTORasterLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.ZoomTORasterLayer_MenuItem.Text = "缩放至图层";
            this.ZoomTORasterLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(185, 6);
            // 
            // OpenFilePathRasterLayer_MenuItem
            // 
            this.OpenFilePathRasterLayer_MenuItem.Name = "OpenFilePathRasterLayer_MenuItem";
            this.OpenFilePathRasterLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.OpenFilePathRasterLayer_MenuItem.Text = "打开文件位置";
            this.OpenFilePathRasterLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // contextMenuStrip_GroupLayer
            // 
            this.contextMenuStrip_GroupLayer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_GroupLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteGroupLayer_MenuItem,
            this.ZoomToGroupLayer_MenuItem,
            this.toolStripSeparator12,
            this.TurnOnAllGroupLayer_MenuItem,
            this.TurnOffAllGroupLayer_MenuItem,
            this.ClearAllGroupLayer_MenuItem,
            this.toolStripSeparator13,
            this.OpenFilePathGroupLayer_MenuItem});
            this.contextMenuStrip_GroupLayer.Name = "map_MenuStrip1";
            this.contextMenuStrip_GroupLayer.Size = new System.Drawing.Size(189, 184);
            this.contextMenuStrip_GroupLayer.VisibleChanged += new System.EventHandler(this.ContextMenuStrip_VisibleChanged);
            // 
            // DeleteGroupLayer_MenuItem
            // 
            this.DeleteGroupLayer_MenuItem.Name = "DeleteGroupLayer_MenuItem";
            this.DeleteGroupLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.DeleteGroupLayer_MenuItem.Text = "删除图层";
            this.DeleteGroupLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // ZoomToGroupLayer_MenuItem
            // 
            this.ZoomToGroupLayer_MenuItem.Name = "ZoomToGroupLayer_MenuItem";
            this.ZoomToGroupLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.ZoomToGroupLayer_MenuItem.Text = "缩放至图层";
            this.ZoomToGroupLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(185, 6);
            // 
            // TurnOnAllGroupLayer_MenuItem
            // 
            this.TurnOnAllGroupLayer_MenuItem.Name = "TurnOnAllGroupLayer_MenuItem";
            this.TurnOnAllGroupLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.TurnOnAllGroupLayer_MenuItem.Text = "显示所有图层";
            this.TurnOnAllGroupLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // TurnOffAllGroupLayer_MenuItem
            // 
            this.TurnOffAllGroupLayer_MenuItem.Name = "TurnOffAllGroupLayer_MenuItem";
            this.TurnOffAllGroupLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.TurnOffAllGroupLayer_MenuItem.Text = "隐藏所有图层";
            this.TurnOffAllGroupLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // ClearAllGroupLayer_MenuItem
            // 
            this.ClearAllGroupLayer_MenuItem.Name = "ClearAllGroupLayer_MenuItem";
            this.ClearAllGroupLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.ClearAllGroupLayer_MenuItem.Text = "清除所有图层";
            this.ClearAllGroupLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(185, 6);
            // 
            // OpenFilePathGroupLayer_MenuItem
            // 
            this.OpenFilePathGroupLayer_MenuItem.Name = "OpenFilePathGroupLayer_MenuItem";
            this.OpenFilePathGroupLayer_MenuItem.Size = new System.Drawing.Size(188, 28);
            this.OpenFilePathGroupLayer_MenuItem.Text = "打开文件位置";
            this.OpenFilePathGroupLayer_MenuItem.Click += new System.EventHandler(this.TOCMenuItem_Click);
            // 
            // lbl_SpatialReference
            // 
            this.lbl_SpatialReference.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_SpatialReference.AutoSize = true;
            this.lbl_SpatialReference.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_SpatialReference.Location = new System.Drawing.Point(495, 936);
            this.lbl_SpatialReference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SpatialReference.Name = "lbl_SpatialReference";
            this.lbl_SpatialReference.Size = new System.Drawing.Size(80, 18);
            this.lbl_SpatialReference.TabIndex = 12;
            this.lbl_SpatialReference.Text = "坐标系：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1040, 936);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "地图坐标：";
            // 
            // txtBox_GeoCoord
            // 
            this.txtBox_GeoCoord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBox_GeoCoord.Location = new System.Drawing.Point(1132, 932);
            this.txtBox_GeoCoord.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_GeoCoord.Name = "txtBox_GeoCoord";
            this.txtBox_GeoCoord.Size = new System.Drawing.Size(253, 28);
            this.txtBox_GeoCoord.TabIndex = 16;
            // 
            // txtBox_PiexlCoord
            // 
            this.txtBox_PiexlCoord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBox_PiexlCoord.Location = new System.Drawing.Point(1524, 932);
            this.txtBox_PiexlCoord.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_PiexlCoord.Name = "txtBox_PiexlCoord";
            this.txtBox_PiexlCoord.Size = new System.Drawing.Size(139, 28);
            this.txtBox_PiexlCoord.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1431, 936);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "屏幕坐标：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 937);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 960);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtBox_PiexlCoord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_GeoCoord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_SpatialReference);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIESDK开发系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip_Map.ResumeLayout(false);
            this.contextMenuStrip_FeatureLayer.ResumeLayout(false);
            this.contextMenuStrip_RasterLayer.ResumeLayout(false);
            this.contextMenuStrip_GroupLayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_OpenVector;
        private System.Windows.Forms.ToolStripButton toolStripButton_OpenRaster;
        private System.Windows.Forms.ToolStripButton toolStripButton_HDF;
        private System.Windows.Forms.ToolStripButton toolStripButton_ZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripButton_ZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripButton_CenterZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripButton_CenterZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripButton_Pan;
        private System.Windows.Forms.ToolStripButton toolStripButton_FullExtent;
        private System.Windows.Forms.ToolStripButton toolStripButton_OneVOne;
        private System.Windows.Forms.ToolStripButton toolStripButton_PreviousExtent;
        private System.Windows.Forms.ToolStripButton toolStripButton_NextExtent;
        private System.Windows.Forms.ToolStripButton toolStripButton_SwiperLayer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Map;
        private System.Windows.Forms.ToolStripMenuItem ActiveMap_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem VectorLoader_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem RasterLoader_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TurnOnAll_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem TurnOffAll_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearAll_MenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_FeatureLayer;
        private System.Windows.Forms.ToolStripMenuItem DeleteFeatureLayer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomtoFeatureLayer_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem OpenFilePathFeatureLayer_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem AnnotationFeatureLayer_MenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_RasterLayer;
        private System.Windows.Forms.ToolStripMenuItem DeleteRasterLayer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomTORasterLayer_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem OpenFilePathRasterLayer_MenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_GroupLayer;
        private System.Windows.Forms.ToolStripMenuItem DeleteGroupLayer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomToGroupLayer_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem TurnOnAllGroupLayer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem TurnOffAllGroupLayer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearAllGroupLayer_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem OpenFilePathGroupLayer_MenuItem;
        private System.Windows.Forms.Label lbl_SpatialReference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_GeoCoord;
        private System.Windows.Forms.TextBox txtBox_PiexlCoord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_ZoomInDemo;
        private System.Windows.Forms.ToolStripButton toolStripButton_FullExtentDemo;
        private PIE.AxControls.MapControl axMapControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem AttributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ISODATA;
        private System.Windows.Forms.ToolStripButton testButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

