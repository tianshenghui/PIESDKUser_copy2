namespace Sparkle
{
    partial class PCAfusion_FRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb_MultiSpectralSetting = new System.Windows.Forms.GroupBox();
            this.Bn_Clear = new System.Windows.Forms.Button();
            this.Bn_SelectAll = new System.Windows.Forms.Button();
            this.Tb_NumSelectedBand = new System.Windows.Forms.TextBox();
            this.Lb_NumSeletedBand = new System.Windows.Forms.Label();
            this.Lb_BandSetting = new System.Windows.Forms.Label();
            this.Lbox_BandDisplay = new System.Windows.Forms.ListBox();
            this.Bn_InputFile = new System.Windows.Forms.Button();
            this.Tb_InputFile = new System.Windows.Forms.TextBox();
            this.Lb_InputFile = new System.Windows.Forms.Label();
            this.Gb_PanImgSetting = new System.Windows.Forms.GroupBox();
            this.Cb_BandSelect = new System.Windows.Forms.ComboBox();
            this.Lb_BandSetting1 = new System.Windows.Forms.Label();
            this.Bn_InputFile1 = new System.Windows.Forms.Button();
            this.Tb_InputFile1 = new System.Windows.Forms.TextBox();
            this.Lb_InputFile1 = new System.Windows.Forms.Label();
            this.Lb_Resample = new System.Windows.Forms.Label();
            this.Cb_Resample = new System.Windows.Forms.ComboBox();
            this.Lb_OutputFile = new System.Windows.Forms.Label();
            this.Tb_OutputFile = new System.Windows.Forms.TextBox();
            this.Bn_OutputFile = new System.Windows.Forms.Button();
            this.Bn_OK = new System.Windows.Forms.Button();
            this.Bn_Cancel = new System.Windows.Forms.Button();
            this.Gb_MultiSpectralSetting.SuspendLayout();
            this.Gb_PanImgSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_MultiSpectralSetting
            // 
            this.Gb_MultiSpectralSetting.Controls.Add(this.Bn_Clear);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Bn_SelectAll);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Tb_NumSelectedBand);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Lb_NumSeletedBand);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Lb_BandSetting);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Lbox_BandDisplay);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Bn_InputFile);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Tb_InputFile);
            this.Gb_MultiSpectralSetting.Controls.Add(this.Lb_InputFile);
            this.Gb_MultiSpectralSetting.Location = new System.Drawing.Point(22, 27);
            this.Gb_MultiSpectralSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_MultiSpectralSetting.Name = "Gb_MultiSpectralSetting";
            this.Gb_MultiSpectralSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_MultiSpectralSetting.Size = new System.Drawing.Size(550, 292);
            this.Gb_MultiSpectralSetting.TabIndex = 0;
            this.Gb_MultiSpectralSetting.TabStop = false;
            this.Gb_MultiSpectralSetting.Text = "多光谱影像设置";
            // 
            // Bn_Clear
            // 
            this.Bn_Clear.Location = new System.Drawing.Point(446, 239);
            this.Bn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_Clear.Name = "Bn_Clear";
            this.Bn_Clear.Size = new System.Drawing.Size(67, 29);
            this.Bn_Clear.TabIndex = 10;
            this.Bn_Clear.Text = "清空";
            this.Bn_Clear.UseVisualStyleBackColor = true;
            this.Bn_Clear.Click += new System.EventHandler(this.Bn_Clear_Click);
            // 
            // Bn_SelectAll
            // 
            this.Bn_SelectAll.Location = new System.Drawing.Point(277, 239);
            this.Bn_SelectAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_SelectAll.Name = "Bn_SelectAll";
            this.Bn_SelectAll.Size = new System.Drawing.Size(97, 29);
            this.Bn_SelectAll.TabIndex = 9;
            this.Bn_SelectAll.Text = "全选";
            this.Bn_SelectAll.UseVisualStyleBackColor = true;
            this.Bn_SelectAll.Click += new System.EventHandler(this.Bn_SelectAll_Click);
            // 
            // Tb_NumSelectedBand
            // 
            this.Tb_NumSelectedBand.Location = new System.Drawing.Point(105, 242);
            this.Tb_NumSelectedBand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_NumSelectedBand.Name = "Tb_NumSelectedBand";
            this.Tb_NumSelectedBand.Size = new System.Drawing.Size(124, 25);
            this.Tb_NumSelectedBand.TabIndex = 8;
            // 
            // Lb_NumSeletedBand
            // 
            this.Lb_NumSeletedBand.AutoSize = true;
            this.Lb_NumSeletedBand.Location = new System.Drawing.Point(6, 245);
            this.Lb_NumSeletedBand.Name = "Lb_NumSeletedBand";
            this.Lb_NumSeletedBand.Size = new System.Drawing.Size(67, 15);
            this.Lb_NumSeletedBand.TabIndex = 7;
            this.Lb_NumSeletedBand.Text = "选择波段";
            // 
            // Lb_BandSetting
            // 
            this.Lb_BandSetting.AutoSize = true;
            this.Lb_BandSetting.Location = new System.Drawing.Point(6, 117);
            this.Lb_BandSetting.Name = "Lb_BandSetting";
            this.Lb_BandSetting.Size = new System.Drawing.Size(67, 15);
            this.Lb_BandSetting.TabIndex = 6;
            this.Lb_BandSetting.Text = "波段设置";
            this.Lb_BandSetting.Click += new System.EventHandler(this.Lb_BandSetting_Click);
            // 
            // Lbox_BandDisplay
            // 
            this.Lbox_BandDisplay.FormattingEnabled = true;
            this.Lbox_BandDisplay.ItemHeight = 15;
            this.Lbox_BandDisplay.Location = new System.Drawing.Point(105, 67);
            this.Lbox_BandDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lbox_BandDisplay.Name = "Lbox_BandDisplay";
            this.Lbox_BandDisplay.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Lbox_BandDisplay.Size = new System.Drawing.Size(408, 139);
            this.Lbox_BandDisplay.TabIndex = 4;
            this.Lbox_BandDisplay.SelectedIndexChanged += new System.EventHandler(this.Lbox_BandDisplay_SelectedIndexChanged);
            // 
            // Bn_InputFile
            // 
            this.Bn_InputFile.Location = new System.Drawing.Point(461, 23);
            this.Bn_InputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_InputFile.Name = "Bn_InputFile";
            this.Bn_InputFile.Size = new System.Drawing.Size(67, 26);
            this.Bn_InputFile.TabIndex = 3;
            this.Bn_InputFile.Text = "...";
            this.Bn_InputFile.UseVisualStyleBackColor = true;
            this.Bn_InputFile.Click += new System.EventHandler(this.Bn_InputFile_Click);
            // 
            // Tb_InputFile
            // 
            this.Tb_InputFile.Location = new System.Drawing.Point(105, 23);
            this.Tb_InputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_InputFile.Name = "Tb_InputFile";
            this.Tb_InputFile.ReadOnly = true;
            this.Tb_InputFile.Size = new System.Drawing.Size(336, 25);
            this.Tb_InputFile.TabIndex = 1;
            // 
            // Lb_InputFile
            // 
            this.Lb_InputFile.AutoSize = true;
            this.Lb_InputFile.Location = new System.Drawing.Point(6, 23);
            this.Lb_InputFile.Name = "Lb_InputFile";
            this.Lb_InputFile.Size = new System.Drawing.Size(67, 15);
            this.Lb_InputFile.TabIndex = 0;
            this.Lb_InputFile.Text = "输入文件";
            // 
            // Gb_PanImgSetting
            // 
            this.Gb_PanImgSetting.Controls.Add(this.Cb_BandSelect);
            this.Gb_PanImgSetting.Controls.Add(this.Lb_BandSetting1);
            this.Gb_PanImgSetting.Controls.Add(this.Bn_InputFile1);
            this.Gb_PanImgSetting.Controls.Add(this.Tb_InputFile1);
            this.Gb_PanImgSetting.Controls.Add(this.Lb_InputFile1);
            this.Gb_PanImgSetting.Location = new System.Drawing.Point(22, 347);
            this.Gb_PanImgSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_PanImgSetting.Name = "Gb_PanImgSetting";
            this.Gb_PanImgSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_PanImgSetting.Size = new System.Drawing.Size(550, 107);
            this.Gb_PanImgSetting.TabIndex = 1;
            this.Gb_PanImgSetting.TabStop = false;
            this.Gb_PanImgSetting.Text = "高分辨率影像设置";
            // 
            // Cb_BandSelect
            // 
            this.Cb_BandSelect.FormattingEnabled = true;
            this.Cb_BandSelect.Location = new System.Drawing.Point(105, 69);
            this.Cb_BandSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_BandSelect.Name = "Cb_BandSelect";
            this.Cb_BandSelect.Size = new System.Drawing.Size(181, 23);
            this.Cb_BandSelect.TabIndex = 5;
            this.Cb_BandSelect.Text = "波段1";
            this.Cb_BandSelect.SelectedIndexChanged += new System.EventHandler(this.Cb_BandSelect_SelectedIndexChanged);
            // 
            // Lb_BandSetting1
            // 
            this.Lb_BandSetting1.AutoSize = true;
            this.Lb_BandSetting1.Location = new System.Drawing.Point(19, 69);
            this.Lb_BandSetting1.Name = "Lb_BandSetting1";
            this.Lb_BandSetting1.Size = new System.Drawing.Size(67, 15);
            this.Lb_BandSetting1.TabIndex = 4;
            this.Lb_BandSetting1.Text = "波段设置";
            this.Lb_BandSetting1.Click += new System.EventHandler(this.Lb_BandSetting1_Click);
            // 
            // Bn_InputFile1
            // 
            this.Bn_InputFile1.Location = new System.Drawing.Point(461, 33);
            this.Bn_InputFile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_InputFile1.Name = "Bn_InputFile1";
            this.Bn_InputFile1.Size = new System.Drawing.Size(67, 25);
            this.Bn_InputFile1.TabIndex = 3;
            this.Bn_InputFile1.Text = "...";
            this.Bn_InputFile1.UseVisualStyleBackColor = true;
            this.Bn_InputFile1.Click += new System.EventHandler(this.Bn_InputFile1_Click);
            // 
            // Tb_InputFile1
            // 
            this.Tb_InputFile1.Location = new System.Drawing.Point(105, 33);
            this.Tb_InputFile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_InputFile1.Name = "Tb_InputFile1";
            this.Tb_InputFile1.ReadOnly = true;
            this.Tb_InputFile1.Size = new System.Drawing.Size(336, 25);
            this.Tb_InputFile1.TabIndex = 2;
            // 
            // Lb_InputFile1
            // 
            this.Lb_InputFile1.AutoSize = true;
            this.Lb_InputFile1.Location = new System.Drawing.Point(19, 37);
            this.Lb_InputFile1.Name = "Lb_InputFile1";
            this.Lb_InputFile1.Size = new System.Drawing.Size(67, 15);
            this.Lb_InputFile1.TabIndex = 0;
            this.Lb_InputFile1.Text = "输入文件";
            // 
            // Lb_Resample
            // 
            this.Lb_Resample.AutoSize = true;
            this.Lb_Resample.Location = new System.Drawing.Point(38, 483);
            this.Lb_Resample.Name = "Lb_Resample";
            this.Lb_Resample.Size = new System.Drawing.Size(82, 15);
            this.Lb_Resample.TabIndex = 3;
            this.Lb_Resample.Text = "重采样方法";
            // 
            // Cb_Resample
            // 
            this.Cb_Resample.FormattingEnabled = true;
            this.Cb_Resample.Items.AddRange(new object[] {
            "最近邻域法",
            "双线性插值法",
            "三次卷积法"});
            this.Cb_Resample.Location = new System.Drawing.Point(153, 480);
            this.Cb_Resample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Resample.Name = "Cb_Resample";
            this.Cb_Resample.Size = new System.Drawing.Size(177, 23);
            this.Cb_Resample.TabIndex = 4;
            this.Cb_Resample.Text = "最近邻域法";
            this.Cb_Resample.SelectedIndexChanged += new System.EventHandler(this.Cb_Resample_SelectedIndexChanged);
            // 
            // Lb_OutputFile
            // 
            this.Lb_OutputFile.AutoSize = true;
            this.Lb_OutputFile.Location = new System.Drawing.Point(41, 526);
            this.Lb_OutputFile.Name = "Lb_OutputFile";
            this.Lb_OutputFile.Size = new System.Drawing.Size(67, 15);
            this.Lb_OutputFile.TabIndex = 5;
            this.Lb_OutputFile.Text = "输出文件";
            // 
            // Tb_OutputFile
            // 
            this.Tb_OutputFile.Location = new System.Drawing.Point(127, 520);
            this.Tb_OutputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_OutputFile.Name = "Tb_OutputFile";
            this.Tb_OutputFile.ReadOnly = true;
            this.Tb_OutputFile.Size = new System.Drawing.Size(336, 25);
            this.Tb_OutputFile.TabIndex = 6;
            // 
            // Bn_OutputFile
            // 
            this.Bn_OutputFile.Location = new System.Drawing.Point(483, 520);
            this.Bn_OutputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_OutputFile.Name = "Bn_OutputFile";
            this.Bn_OutputFile.Size = new System.Drawing.Size(67, 25);
            this.Bn_OutputFile.TabIndex = 8;
            this.Bn_OutputFile.Text = "...";
            this.Bn_OutputFile.UseVisualStyleBackColor = true;
            this.Bn_OutputFile.Click += new System.EventHandler(this.Bn_OutputFile_Click);
            // 
            // Bn_OK
            // 
            this.Bn_OK.Location = new System.Drawing.Point(44, 574);
            this.Bn_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_OK.Name = "Bn_OK";
            this.Bn_OK.Size = new System.Drawing.Size(69, 31);
            this.Bn_OK.TabIndex = 9;
            this.Bn_OK.Text = "确定";
            this.Bn_OK.UseVisualStyleBackColor = true;
            this.Bn_OK.Click += new System.EventHandler(this.Bn_OK_Click);
            // 
            // Bn_Cancel
            // 
            this.Bn_Cancel.Location = new System.Drawing.Point(482, 574);
            this.Bn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_Cancel.Name = "Bn_Cancel";
            this.Bn_Cancel.Size = new System.Drawing.Size(68, 31);
            this.Bn_Cancel.TabIndex = 10;
            this.Bn_Cancel.Text = "取消";
            this.Bn_Cancel.UseVisualStyleBackColor = true;
            this.Bn_Cancel.Click += new System.EventHandler(this.Bn_Cancel_Click);
            // 
            // PCAfusion_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 653);
            this.Controls.Add(this.Bn_Cancel);
            this.Controls.Add(this.Bn_OK);
            this.Controls.Add(this.Bn_OutputFile);
            this.Controls.Add(this.Tb_OutputFile);
            this.Controls.Add(this.Lb_OutputFile);
            this.Controls.Add(this.Cb_Resample);
            this.Controls.Add(this.Lb_Resample);
            this.Controls.Add(this.Gb_PanImgSetting);
            this.Controls.Add(this.Gb_MultiSpectralSetting);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PCAfusion_FRM";
            this.Text = "PCA融合";
            this.Gb_MultiSpectralSetting.ResumeLayout(false);
            this.Gb_MultiSpectralSetting.PerformLayout();
            this.Gb_PanImgSetting.ResumeLayout(false);
            this.Gb_PanImgSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_MultiSpectralSetting;
        private System.Windows.Forms.ListBox Lbox_BandDisplay;
        private System.Windows.Forms.Button Bn_InputFile;
        private System.Windows.Forms.TextBox Tb_InputFile;
        private System.Windows.Forms.Label Lb_InputFile;
        private System.Windows.Forms.GroupBox Gb_PanImgSetting;
        private System.Windows.Forms.Button Bn_Clear;
        private System.Windows.Forms.Button Bn_SelectAll;
        private System.Windows.Forms.TextBox Tb_NumSelectedBand;
        private System.Windows.Forms.Label Lb_NumSeletedBand;
        private System.Windows.Forms.Label Lb_BandSetting;
        private System.Windows.Forms.ComboBox Cb_BandSelect;
        private System.Windows.Forms.Label Lb_BandSetting1;
        private System.Windows.Forms.Button Bn_InputFile1;
        private System.Windows.Forms.TextBox Tb_InputFile1;
        private System.Windows.Forms.Label Lb_InputFile1;
        private System.Windows.Forms.Label Lb_Resample;
        private System.Windows.Forms.ComboBox Cb_Resample;
        private System.Windows.Forms.Label Lb_OutputFile;
        private System.Windows.Forms.TextBox Tb_OutputFile;
        private System.Windows.Forms.Button Bn_OutputFile;
        private System.Windows.Forms.Button Bn_OK;
        private System.Windows.Forms.Button Bn_Cancel;
    }
}