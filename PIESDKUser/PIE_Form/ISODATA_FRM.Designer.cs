namespace Sparkle
{
    partial class ISODATA_FRM
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
            this.Tb_InputFile = new System.Windows.Forms.TextBox();
            this.Bn_ChooseFile = new System.Windows.Forms.Button();
            this.Lb_InputFile = new System.Windows.Forms.Label();
            this.Gb_BandSelect = new System.Windows.Forms.GroupBox();
            this.LB_BandDisplay = new System.Windows.Forms.ListBox();
            this.Bn_ClearBand = new System.Windows.Forms.Button();
            this.Lb_SelectedBandNum = new System.Windows.Forms.Label();
            this.Lb_BandNum = new System.Windows.Forms.Label();
            this.Gb_ParamSetting = new System.Windows.Forms.GroupBox();
            this.Tb_MinCenDistance = new System.Windows.Forms.TextBox();
            this.Tb_MaxSD = new System.Windows.Forms.TextBox();
            this.Lb_MaxComCpNum = new System.Windows.Forms.Label();
            this.Lb_MinCenDistance = new System.Windows.Forms.Label();
            this.Lb_MaxSD = new System.Windows.Forms.Label();
            this.Lb_MaxIteraNum = new System.Windows.Forms.Label();
            this.Lb_MinPixelNum = new System.Windows.Forms.Label();
            this.Lb_InitCateNum = new System.Windows.Forms.Label();
            this.Lb_PreCateNum = new System.Windows.Forms.Label();
            this.Bn_Excecute = new System.Windows.Forms.Button();
            this.Lb_ExportFile = new System.Windows.Forms.Label();
            this.Tb_OutputPath = new System.Windows.Forms.TextBox();
            this.Bn_SaveAs = new System.Windows.Forms.Button();
            this.Bn_Cancel = new System.Windows.Forms.Button();
            this.nud_PreCateNum = new System.Windows.Forms.NumericUpDown();
            this.nud_InitCateNum = new System.Windows.Forms.NumericUpDown();
            this.nud_MinPixelNum = new System.Windows.Forms.NumericUpDown();
            this.nud_MaxIteraNum = new System.Windows.Forms.NumericUpDown();
            this.nud_MaxComCpNum = new System.Windows.Forms.NumericUpDown();
            this.Gb_BandSelect.SuspendLayout();
            this.Gb_ParamSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PreCateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_InitCateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinPixelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxIteraNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxComCpNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_InputFile
            // 
            this.Tb_InputFile.Location = new System.Drawing.Point(121, 30);
            this.Tb_InputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_InputFile.Name = "Tb_InputFile";
            this.Tb_InputFile.ReadOnly = true;
            this.Tb_InputFile.Size = new System.Drawing.Size(369, 25);
            this.Tb_InputFile.TabIndex = 1;
            // 
            // Bn_ChooseFile
            // 
            this.Bn_ChooseFile.Location = new System.Drawing.Point(513, 27);
            this.Bn_ChooseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_ChooseFile.Name = "Bn_ChooseFile";
            this.Bn_ChooseFile.Size = new System.Drawing.Size(105, 33);
            this.Bn_ChooseFile.TabIndex = 3;
            this.Bn_ChooseFile.Text = "...";
            this.Bn_ChooseFile.UseVisualStyleBackColor = true;
            this.Bn_ChooseFile.Click += new System.EventHandler(this.Bn_ChooseFile_Click);
            // 
            // Lb_InputFile
            // 
            this.Lb_InputFile.AutoSize = true;
            this.Lb_InputFile.Location = new System.Drawing.Point(29, 35);
            this.Lb_InputFile.Name = "Lb_InputFile";
            this.Lb_InputFile.Size = new System.Drawing.Size(67, 15);
            this.Lb_InputFile.TabIndex = 4;
            this.Lb_InputFile.Text = "输入文件";
            // 
            // Gb_BandSelect
            // 
            this.Gb_BandSelect.Controls.Add(this.LB_BandDisplay);
            this.Gb_BandSelect.Controls.Add(this.Bn_ClearBand);
            this.Gb_BandSelect.Controls.Add(this.Lb_SelectedBandNum);
            this.Gb_BandSelect.Controls.Add(this.Lb_BandNum);
            this.Gb_BandSelect.Location = new System.Drawing.Point(32, 83);
            this.Gb_BandSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_BandSelect.Name = "Gb_BandSelect";
            this.Gb_BandSelect.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_BandSelect.Size = new System.Drawing.Size(301, 377);
            this.Gb_BandSelect.TabIndex = 5;
            this.Gb_BandSelect.TabStop = false;
            this.Gb_BandSelect.Text = "波段选择";
            // 
            // LB_BandDisplay
            // 
            this.LB_BandDisplay.FormattingEnabled = true;
            this.LB_BandDisplay.ItemHeight = 15;
            this.LB_BandDisplay.Location = new System.Drawing.Point(17, 22);
            this.LB_BandDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB_BandDisplay.Name = "LB_BandDisplay";
            this.LB_BandDisplay.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_BandDisplay.Size = new System.Drawing.Size(263, 289);
            this.LB_BandDisplay.TabIndex = 6;
            this.LB_BandDisplay.SelectedIndexChanged += new System.EventHandler(this.LB_BandDisplay_SelectedIndexChanged);
            // 
            // Bn_ClearBand
            // 
            this.Bn_ClearBand.Location = new System.Drawing.Point(207, 338);
            this.Bn_ClearBand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_ClearBand.Name = "Bn_ClearBand";
            this.Bn_ClearBand.Size = new System.Drawing.Size(73, 30);
            this.Bn_ClearBand.TabIndex = 2;
            this.Bn_ClearBand.Text = "清空";
            this.Bn_ClearBand.UseVisualStyleBackColor = true;
            this.Bn_ClearBand.Click += new System.EventHandler(this.Bn_ClearBand_Click);
            // 
            // Lb_SelectedBandNum
            // 
            this.Lb_SelectedBandNum.AutoSize = true;
            this.Lb_SelectedBandNum.Location = new System.Drawing.Point(5, 345);
            this.Lb_SelectedBandNum.Name = "Lb_SelectedBandNum";
            this.Lb_SelectedBandNum.Size = new System.Drawing.Size(112, 15);
            this.Lb_SelectedBandNum.TabIndex = 1;
            this.Lb_SelectedBandNum.Text = "选中波段数目：";
            // 
            // Lb_BandNum
            // 
            this.Lb_BandNum.AutoSize = true;
            this.Lb_BandNum.Location = new System.Drawing.Point(157, 345);
            this.Lb_BandNum.Name = "Lb_BandNum";
            this.Lb_BandNum.Size = new System.Drawing.Size(0, 15);
            this.Lb_BandNum.TabIndex = 0;
            // 
            // Gb_ParamSetting
            // 
            this.Gb_ParamSetting.Controls.Add(this.nud_MaxComCpNum);
            this.Gb_ParamSetting.Controls.Add(this.nud_MaxIteraNum);
            this.Gb_ParamSetting.Controls.Add(this.nud_MinPixelNum);
            this.Gb_ParamSetting.Controls.Add(this.nud_InitCateNum);
            this.Gb_ParamSetting.Controls.Add(this.nud_PreCateNum);
            this.Gb_ParamSetting.Controls.Add(this.Tb_MinCenDistance);
            this.Gb_ParamSetting.Controls.Add(this.Tb_MaxSD);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MaxComCpNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MinCenDistance);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MaxSD);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MaxIteraNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MinPixelNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_InitCateNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_PreCateNum);
            this.Gb_ParamSetting.Location = new System.Drawing.Point(373, 91);
            this.Gb_ParamSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_ParamSetting.Name = "Gb_ParamSetting";
            this.Gb_ParamSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_ParamSetting.Size = new System.Drawing.Size(315, 369);
            this.Gb_ParamSetting.TabIndex = 6;
            this.Gb_ParamSetting.TabStop = false;
            this.Gb_ParamSetting.Text = "参数设置";
            // 
            // Tb_MinCenDistance
            // 
            this.Tb_MinCenDistance.Location = new System.Drawing.Point(174, 251);
            this.Tb_MinCenDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_MinCenDistance.Name = "Tb_MinCenDistance";
            this.Tb_MinCenDistance.Size = new System.Drawing.Size(62, 25);
            this.Tb_MinCenDistance.TabIndex = 19;
            this.Tb_MinCenDistance.Text = "5";
            // 
            // Tb_MaxSD
            // 
            this.Tb_MaxSD.Location = new System.Drawing.Point(174, 204);
            this.Tb_MaxSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_MaxSD.Name = "Tb_MaxSD";
            this.Tb_MaxSD.Size = new System.Drawing.Size(62, 25);
            this.Tb_MaxSD.TabIndex = 18;
            this.Tb_MaxSD.Text = "9";
            // 
            // Lb_MaxComCpNum
            // 
            this.Lb_MaxComCpNum.AutoSize = true;
            this.Lb_MaxComCpNum.Location = new System.Drawing.Point(13, 296);
            this.Lb_MaxComCpNum.Name = "Lb_MaxComCpNum";
            this.Lb_MaxComCpNum.Size = new System.Drawing.Size(112, 15);
            this.Lb_MaxComCpNum.TabIndex = 13;
            this.Lb_MaxComCpNum.Text = "最大合并对数：";
            // 
            // Lb_MinCenDistance
            // 
            this.Lb_MinCenDistance.AutoSize = true;
            this.Lb_MinCenDistance.Location = new System.Drawing.Point(13, 254);
            this.Lb_MinCenDistance.Name = "Lb_MinCenDistance";
            this.Lb_MinCenDistance.Size = new System.Drawing.Size(112, 15);
            this.Lb_MinCenDistance.TabIndex = 12;
            this.Lb_MinCenDistance.Text = "最小中心距离：";
            // 
            // Lb_MaxSD
            // 
            this.Lb_MaxSD.AutoSize = true;
            this.Lb_MaxSD.Location = new System.Drawing.Point(13, 211);
            this.Lb_MaxSD.Name = "Lb_MaxSD";
            this.Lb_MaxSD.Size = new System.Drawing.Size(97, 15);
            this.Lb_MaxSD.TabIndex = 11;
            this.Lb_MaxSD.Text = "最大标准差：";
            // 
            // Lb_MaxIteraNum
            // 
            this.Lb_MaxIteraNum.AutoSize = true;
            this.Lb_MaxIteraNum.Location = new System.Drawing.Point(13, 167);
            this.Lb_MaxIteraNum.Name = "Lb_MaxIteraNum";
            this.Lb_MaxIteraNum.Size = new System.Drawing.Size(112, 15);
            this.Lb_MaxIteraNum.TabIndex = 10;
            this.Lb_MaxIteraNum.Text = "最大迭代次数：";
            // 
            // Lb_MinPixelNum
            // 
            this.Lb_MinPixelNum.AutoSize = true;
            this.Lb_MinPixelNum.Location = new System.Drawing.Point(13, 123);
            this.Lb_MinPixelNum.Name = "Lb_MinPixelNum";
            this.Lb_MinPixelNum.Size = new System.Drawing.Size(97, 15);
            this.Lb_MinPixelNum.TabIndex = 9;
            this.Lb_MinPixelNum.Text = "最少像元数：";
            // 
            // Lb_InitCateNum
            // 
            this.Lb_InitCateNum.AutoSize = true;
            this.Lb_InitCateNum.Location = new System.Drawing.Point(13, 77);
            this.Lb_InitCateNum.Name = "Lb_InitCateNum";
            this.Lb_InitCateNum.Size = new System.Drawing.Size(82, 15);
            this.Lb_InitCateNum.TabIndex = 8;
            this.Lb_InitCateNum.Text = "初始类数：";
            // 
            // Lb_PreCateNum
            // 
            this.Lb_PreCateNum.AutoSize = true;
            this.Lb_PreCateNum.Location = new System.Drawing.Point(13, 38);
            this.Lb_PreCateNum.Name = "Lb_PreCateNum";
            this.Lb_PreCateNum.Size = new System.Drawing.Size(82, 15);
            this.Lb_PreCateNum.TabIndex = 7;
            this.Lb_PreCateNum.Text = "预期类数：";
            // 
            // Bn_Excecute
            // 
            this.Bn_Excecute.Location = new System.Drawing.Point(49, 581);
            this.Bn_Excecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_Excecute.Name = "Bn_Excecute";
            this.Bn_Excecute.Size = new System.Drawing.Size(87, 32);
            this.Bn_Excecute.TabIndex = 7;
            this.Bn_Excecute.Text = "确定";
            this.Bn_Excecute.UseVisualStyleBackColor = true;
            this.Bn_Excecute.Click += new System.EventHandler(this.Bn_Excecute_Click);
            // 
            // Lb_ExportFile
            // 
            this.Lb_ExportFile.AutoSize = true;
            this.Lb_ExportFile.Location = new System.Drawing.Point(29, 498);
            this.Lb_ExportFile.Name = "Lb_ExportFile";
            this.Lb_ExportFile.Size = new System.Drawing.Size(67, 15);
            this.Lb_ExportFile.TabIndex = 8;
            this.Lb_ExportFile.Text = "输出文件";
            // 
            // Tb_OutputPath
            // 
            this.Tb_OutputPath.Location = new System.Drawing.Point(121, 493);
            this.Tb_OutputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_OutputPath.Name = "Tb_OutputPath";
            this.Tb_OutputPath.ReadOnly = true;
            this.Tb_OutputPath.Size = new System.Drawing.Size(369, 25);
            this.Tb_OutputPath.TabIndex = 9;
            // 
            // Bn_SaveAs
            // 
            this.Bn_SaveAs.Location = new System.Drawing.Point(513, 488);
            this.Bn_SaveAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_SaveAs.Name = "Bn_SaveAs";
            this.Bn_SaveAs.Size = new System.Drawing.Size(105, 33);
            this.Bn_SaveAs.TabIndex = 11;
            this.Bn_SaveAs.Text = "...";
            this.Bn_SaveAs.UseVisualStyleBackColor = true;
            this.Bn_SaveAs.Click += new System.EventHandler(this.Bn_SaveAs_Click);
            // 
            // Bn_Cancel
            // 
            this.Bn_Cancel.Location = new System.Drawing.Point(513, 581);
            this.Bn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bn_Cancel.Name = "Bn_Cancel";
            this.Bn_Cancel.Size = new System.Drawing.Size(105, 32);
            this.Bn_Cancel.TabIndex = 12;
            this.Bn_Cancel.Text = "取消";
            this.Bn_Cancel.UseVisualStyleBackColor = true;
            this.Bn_Cancel.Click += new System.EventHandler(this.Bn_Cancel_Click);
            // 
            // nud_PreCateNum
            // 
            this.nud_PreCateNum.Location = new System.Drawing.Point(174, 35);
            this.nud_PreCateNum.Name = "nud_PreCateNum";
            this.nud_PreCateNum.Size = new System.Drawing.Size(59, 25);
            this.nud_PreCateNum.TabIndex = 21;
            this.nud_PreCateNum.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nud_InitCateNum
            // 
            this.nud_InitCateNum.Location = new System.Drawing.Point(174, 66);
            this.nud_InitCateNum.Name = "nud_InitCateNum";
            this.nud_InitCateNum.Size = new System.Drawing.Size(59, 25);
            this.nud_InitCateNum.TabIndex = 22;
            this.nud_InitCateNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_MinPixelNum
            // 
            this.nud_MinPixelNum.Location = new System.Drawing.Point(174, 113);
            this.nud_MinPixelNum.Name = "nud_MinPixelNum";
            this.nud_MinPixelNum.Size = new System.Drawing.Size(59, 25);
            this.nud_MinPixelNum.TabIndex = 23;
            this.nud_MinPixelNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nud_MaxIteraNum
            // 
            this.nud_MaxIteraNum.Location = new System.Drawing.Point(174, 157);
            this.nud_MaxIteraNum.Name = "nud_MaxIteraNum";
            this.nud_MaxIteraNum.Size = new System.Drawing.Size(62, 25);
            this.nud_MaxIteraNum.TabIndex = 24;
            this.nud_MaxIteraNum.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nud_MaxComCpNum
            // 
            this.nud_MaxComCpNum.Location = new System.Drawing.Point(174, 291);
            this.nud_MaxComCpNum.Name = "nud_MaxComCpNum";
            this.nud_MaxComCpNum.Size = new System.Drawing.Size(62, 25);
            this.nud_MaxComCpNum.TabIndex = 25;
            this.nud_MaxComCpNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ISODATA_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 687);
            this.Controls.Add(this.Bn_Cancel);
            this.Controls.Add(this.Bn_SaveAs);
            this.Controls.Add(this.Tb_OutputPath);
            this.Controls.Add(this.Lb_ExportFile);
            this.Controls.Add(this.Bn_Excecute);
            this.Controls.Add(this.Gb_ParamSetting);
            this.Controls.Add(this.Gb_BandSelect);
            this.Controls.Add(this.Lb_InputFile);
            this.Controls.Add(this.Bn_ChooseFile);
            this.Controls.Add(this.Tb_InputFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ISODATA_FRM";
            this.Text = "ISODATA分类";
            this.Gb_BandSelect.ResumeLayout(false);
            this.Gb_BandSelect.PerformLayout();
            this.Gb_ParamSetting.ResumeLayout(false);
            this.Gb_ParamSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PreCateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_InitCateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinPixelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxIteraNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxComCpNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_InputFile;
        private System.Windows.Forms.Button Bn_ChooseFile;
        private System.Windows.Forms.Label Lb_InputFile;
        private System.Windows.Forms.GroupBox Gb_BandSelect;
        private System.Windows.Forms.Button Bn_ClearBand;
        private System.Windows.Forms.Label Lb_SelectedBandNum;
        private System.Windows.Forms.Label Lb_BandNum;
        private System.Windows.Forms.ListBox LB_BandDisplay;
        private System.Windows.Forms.GroupBox Gb_ParamSetting;
        private System.Windows.Forms.Label Lb_MaxComCpNum;
        private System.Windows.Forms.Label Lb_MinCenDistance;
        private System.Windows.Forms.Label Lb_MaxSD;
        private System.Windows.Forms.Label Lb_MaxIteraNum;
        private System.Windows.Forms.Label Lb_MinPixelNum;
        private System.Windows.Forms.Label Lb_InitCateNum;
        private System.Windows.Forms.Label Lb_PreCateNum;
        private System.Windows.Forms.TextBox Tb_MinCenDistance;
        private System.Windows.Forms.TextBox Tb_MaxSD;
        private System.Windows.Forms.Button Bn_Excecute;
        private System.Windows.Forms.Label Lb_ExportFile;
        private System.Windows.Forms.TextBox Tb_OutputPath;
        private System.Windows.Forms.Button Bn_SaveAs;
        private System.Windows.Forms.Button Bn_Cancel;
        private System.Windows.Forms.NumericUpDown nud_MaxComCpNum;
        private System.Windows.Forms.NumericUpDown nud_MaxIteraNum;
        private System.Windows.Forms.NumericUpDown nud_MinPixelNum;
        private System.Windows.Forms.NumericUpDown nud_InitCateNum;
        private System.Windows.Forms.NumericUpDown nud_PreCateNum;
    }
}