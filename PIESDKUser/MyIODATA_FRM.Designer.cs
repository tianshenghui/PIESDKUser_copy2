namespace PIESDKUser
{
    partial class MyIODATA_FRM
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
            this.Lb_BandNum = new System.Windows.Forms.Label();
            this.Lb_SelectedBandNum = new System.Windows.Forms.Label();
            this.Bn_ClearBand = new System.Windows.Forms.Button();
            this.LB_BandDisplay = new System.Windows.Forms.ListBox();
            this.Gb_ParamSetting = new System.Windows.Forms.GroupBox();
            this.Lb_PreCateNum = new System.Windows.Forms.Label();
            this.Lb_InitCateNum = new System.Windows.Forms.Label();
            this.Lb_MinPixelNum = new System.Windows.Forms.Label();
            this.Lb_MaxIteraNum = new System.Windows.Forms.Label();
            this.Lb_MaxSD = new System.Windows.Forms.Label();
            this.Lb_MinCenDistance = new System.Windows.Forms.Label();
            this.Lb_MaxComCpNum = new System.Windows.Forms.Label();
            this.Tb_PreCateNum = new System.Windows.Forms.TextBox();
            this.Tb_InitCateNum = new System.Windows.Forms.TextBox();
            this.Tb_MinPixelNum = new System.Windows.Forms.TextBox();
            this.Tb_MaxIteraNum = new System.Windows.Forms.TextBox();
            this.Tb_MaxSD = new System.Windows.Forms.TextBox();
            this.Tb_MinCenDistance = new System.Windows.Forms.TextBox();
            this.Tb_MaxComCpNum = new System.Windows.Forms.TextBox();
            this.Bn_Excecute = new System.Windows.Forms.Button();
            this.Lb_ExportFile = new System.Windows.Forms.Label();
            this.Tb_OutputPath = new System.Windows.Forms.TextBox();
            this.Bn_SaveAs = new System.Windows.Forms.Button();
            this.Gb_BandSelect.SuspendLayout();
            this.Gb_ParamSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_InputFile
            // 
            this.Tb_InputFile.Location = new System.Drawing.Point(136, 36);
            this.Tb_InputFile.Name = "Tb_InputFile";
            this.Tb_InputFile.Size = new System.Drawing.Size(415, 28);
            this.Tb_InputFile.TabIndex = 1;
            // 
            // Bn_ChooseFile
            // 
            this.Bn_ChooseFile.Location = new System.Drawing.Point(577, 36);
            this.Bn_ChooseFile.Name = "Bn_ChooseFile";
            this.Bn_ChooseFile.Size = new System.Drawing.Size(91, 28);
            this.Bn_ChooseFile.TabIndex = 3;
            this.Bn_ChooseFile.Text = "...";
            this.Bn_ChooseFile.UseVisualStyleBackColor = true;
            this.Bn_ChooseFile.Click += new System.EventHandler(this.Bn_ChooseFile_Click);
            // 
            // Lb_InputFile
            // 
            this.Lb_InputFile.AutoSize = true;
            this.Lb_InputFile.Location = new System.Drawing.Point(33, 41);
            this.Lb_InputFile.Name = "Lb_InputFile";
            this.Lb_InputFile.Size = new System.Drawing.Size(80, 18);
            this.Lb_InputFile.TabIndex = 4;
            this.Lb_InputFile.Text = "输入文件";
            // 
            // Gb_BandSelect
            // 
            this.Gb_BandSelect.Controls.Add(this.LB_BandDisplay);
            this.Gb_BandSelect.Controls.Add(this.Bn_ClearBand);
            this.Gb_BandSelect.Controls.Add(this.Lb_SelectedBandNum);
            this.Gb_BandSelect.Controls.Add(this.Lb_BandNum);
            this.Gb_BandSelect.Location = new System.Drawing.Point(36, 100);
            this.Gb_BandSelect.Name = "Gb_BandSelect";
            this.Gb_BandSelect.Size = new System.Drawing.Size(273, 453);
            this.Gb_BandSelect.TabIndex = 5;
            this.Gb_BandSelect.TabStop = false;
            this.Gb_BandSelect.Text = "波段选择";
            // 
            // Lb_BandNum
            // 
            this.Lb_BandNum.AutoSize = true;
            this.Lb_BandNum.Location = new System.Drawing.Point(146, 420);
            this.Lb_BandNum.Name = "Lb_BandNum";
            this.Lb_BandNum.Size = new System.Drawing.Size(0, 18);
            this.Lb_BandNum.TabIndex = 0;
            // 
            // Lb_SelectedBandNum
            // 
            this.Lb_SelectedBandNum.AutoSize = true;
            this.Lb_SelectedBandNum.Location = new System.Drawing.Point(6, 420);
            this.Lb_SelectedBandNum.Name = "Lb_SelectedBandNum";
            this.Lb_SelectedBandNum.Size = new System.Drawing.Size(134, 18);
            this.Lb_SelectedBandNum.TabIndex = 1;
            this.Lb_SelectedBandNum.Text = "选中波段数目：";
            // 
            // Bn_ClearBand
            // 
            this.Bn_ClearBand.Location = new System.Drawing.Point(177, 416);
            this.Bn_ClearBand.Name = "Bn_ClearBand";
            this.Bn_ClearBand.Size = new System.Drawing.Size(75, 27);
            this.Bn_ClearBand.TabIndex = 2;
            this.Bn_ClearBand.UseVisualStyleBackColor = true;
            // 
            // LB_BandDisplay
            // 
            this.LB_BandDisplay.FormattingEnabled = true;
            this.LB_BandDisplay.ItemHeight = 18;
            this.LB_BandDisplay.Location = new System.Drawing.Point(20, 27);
            this.LB_BandDisplay.Name = "LB_BandDisplay";
            this.LB_BandDisplay.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_BandDisplay.Size = new System.Drawing.Size(232, 382);
            this.LB_BandDisplay.TabIndex = 6;
            // 
            // Gb_ParamSetting
            // 
            this.Gb_ParamSetting.Controls.Add(this.Tb_MaxComCpNum);
            this.Gb_ParamSetting.Controls.Add(this.Tb_MinCenDistance);
            this.Gb_ParamSetting.Controls.Add(this.Tb_MaxSD);
            this.Gb_ParamSetting.Controls.Add(this.Tb_MaxIteraNum);
            this.Gb_ParamSetting.Controls.Add(this.Tb_MinPixelNum);
            this.Gb_ParamSetting.Controls.Add(this.Tb_InitCateNum);
            this.Gb_ParamSetting.Controls.Add(this.Tb_PreCateNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MaxComCpNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MinCenDistance);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MaxSD);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MaxIteraNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_MinPixelNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_InitCateNum);
            this.Gb_ParamSetting.Controls.Add(this.Lb_PreCateNum);
            this.Gb_ParamSetting.Location = new System.Drawing.Point(351, 110);
            this.Gb_ParamSetting.Name = "Gb_ParamSetting";
            this.Gb_ParamSetting.Size = new System.Drawing.Size(265, 443);
            this.Gb_ParamSetting.TabIndex = 6;
            this.Gb_ParamSetting.TabStop = false;
            this.Gb_ParamSetting.Text = "参数设置";
            // 
            // Lb_PreCateNum
            // 
            this.Lb_PreCateNum.AutoSize = true;
            this.Lb_PreCateNum.Location = new System.Drawing.Point(15, 37);
            this.Lb_PreCateNum.Name = "Lb_PreCateNum";
            this.Lb_PreCateNum.Size = new System.Drawing.Size(98, 18);
            this.Lb_PreCateNum.TabIndex = 7;
            this.Lb_PreCateNum.Text = "预期类数：";
            // 
            // Lb_InitCateNum
            // 
            this.Lb_InitCateNum.AutoSize = true;
            this.Lb_InitCateNum.Location = new System.Drawing.Point(15, 84);
            this.Lb_InitCateNum.Name = "Lb_InitCateNum";
            this.Lb_InitCateNum.Size = new System.Drawing.Size(98, 18);
            this.Lb_InitCateNum.TabIndex = 8;
            this.Lb_InitCateNum.Text = "初始类数：";
            // 
            // Lb_MinPixelNum
            // 
            this.Lb_MinPixelNum.AutoSize = true;
            this.Lb_MinPixelNum.Location = new System.Drawing.Point(15, 128);
            this.Lb_MinPixelNum.Name = "Lb_MinPixelNum";
            this.Lb_MinPixelNum.Size = new System.Drawing.Size(116, 18);
            this.Lb_MinPixelNum.TabIndex = 9;
            this.Lb_MinPixelNum.Text = "最少像元数：";
            // 
            // Lb_MaxIteraNum
            // 
            this.Lb_MaxIteraNum.AutoSize = true;
            this.Lb_MaxIteraNum.Location = new System.Drawing.Point(15, 175);
            this.Lb_MaxIteraNum.Name = "Lb_MaxIteraNum";
            this.Lb_MaxIteraNum.Size = new System.Drawing.Size(134, 18);
            this.Lb_MaxIteraNum.TabIndex = 10;
            this.Lb_MaxIteraNum.Text = "最大迭代次数：";
            // 
            // Lb_MaxSD
            // 
            this.Lb_MaxSD.AutoSize = true;
            this.Lb_MaxSD.Location = new System.Drawing.Point(15, 220);
            this.Lb_MaxSD.Name = "Lb_MaxSD";
            this.Lb_MaxSD.Size = new System.Drawing.Size(116, 18);
            this.Lb_MaxSD.TabIndex = 11;
            this.Lb_MaxSD.Text = "最大标准差：";
            // 
            // Lb_MinCenDistance
            // 
            this.Lb_MinCenDistance.AutoSize = true;
            this.Lb_MinCenDistance.Location = new System.Drawing.Point(15, 262);
            this.Lb_MinCenDistance.Name = "Lb_MinCenDistance";
            this.Lb_MinCenDistance.Size = new System.Drawing.Size(134, 18);
            this.Lb_MinCenDistance.TabIndex = 12;
            this.Lb_MinCenDistance.Text = "最小中心距离：";
            // 
            // Lb_MaxComCpNum
            // 
            this.Lb_MaxComCpNum.AutoSize = true;
            this.Lb_MaxComCpNum.Location = new System.Drawing.Point(15, 304);
            this.Lb_MaxComCpNum.Name = "Lb_MaxComCpNum";
            this.Lb_MaxComCpNum.Size = new System.Drawing.Size(134, 18);
            this.Lb_MaxComCpNum.TabIndex = 13;
            this.Lb_MaxComCpNum.Text = "最大合并对数：";
            // 
            // Tb_PreCateNum
            // 
            this.Tb_PreCateNum.Location = new System.Drawing.Point(148, 34);
            this.Tb_PreCateNum.Name = "Tb_PreCateNum";
            this.Tb_PreCateNum.Size = new System.Drawing.Size(100, 28);
            this.Tb_PreCateNum.TabIndex = 14;
            // 
            // Tb_InitCateNum
            // 
            this.Tb_InitCateNum.Location = new System.Drawing.Point(148, 81);
            this.Tb_InitCateNum.Name = "Tb_InitCateNum";
            this.Tb_InitCateNum.Size = new System.Drawing.Size(100, 28);
            this.Tb_InitCateNum.TabIndex = 15;
            // 
            // Tb_MinPixelNum
            // 
            this.Tb_MinPixelNum.Location = new System.Drawing.Point(148, 125);
            this.Tb_MinPixelNum.Name = "Tb_MinPixelNum";
            this.Tb_MinPixelNum.Size = new System.Drawing.Size(100, 28);
            this.Tb_MinPixelNum.TabIndex = 16;
            // 
            // Tb_MaxIteraNum
            // 
            this.Tb_MaxIteraNum.Location = new System.Drawing.Point(148, 172);
            this.Tb_MaxIteraNum.Name = "Tb_MaxIteraNum";
            this.Tb_MaxIteraNum.Size = new System.Drawing.Size(100, 28);
            this.Tb_MaxIteraNum.TabIndex = 17;
            // 
            // Tb_MaxSD
            // 
            this.Tb_MaxSD.Location = new System.Drawing.Point(148, 217);
            this.Tb_MaxSD.Name = "Tb_MaxSD";
            this.Tb_MaxSD.Size = new System.Drawing.Size(100, 28);
            this.Tb_MaxSD.TabIndex = 18;
            // 
            // Tb_MinCenDistance
            // 
            this.Tb_MinCenDistance.Location = new System.Drawing.Point(148, 259);
            this.Tb_MinCenDistance.Name = "Tb_MinCenDistance";
            this.Tb_MinCenDistance.Size = new System.Drawing.Size(100, 28);
            this.Tb_MinCenDistance.TabIndex = 19;
            // 
            // Tb_MaxComCpNum
            // 
            this.Tb_MaxComCpNum.Location = new System.Drawing.Point(148, 301);
            this.Tb_MaxComCpNum.Name = "Tb_MaxComCpNum";
            this.Tb_MaxComCpNum.Size = new System.Drawing.Size(100, 28);
            this.Tb_MaxComCpNum.TabIndex = 20;
            // 
            // Bn_Excecute
            // 
            this.Bn_Excecute.Location = new System.Drawing.Point(45, 642);
            this.Bn_Excecute.Name = "Bn_Excecute";
            this.Bn_Excecute.Size = new System.Drawing.Size(75, 38);
            this.Bn_Excecute.TabIndex = 7;
            this.Bn_Excecute.Text = "确定";
            this.Bn_Excecute.UseVisualStyleBackColor = true;
            this.Bn_Excecute.Click += new System.EventHandler(this.Bn_Excecute_Click);
            // 
            // Lb_ExportFile
            // 
            this.Lb_ExportFile.AutoSize = true;
            this.Lb_ExportFile.Location = new System.Drawing.Point(36, 589);
            this.Lb_ExportFile.Name = "Lb_ExportFile";
            this.Lb_ExportFile.Size = new System.Drawing.Size(80, 18);
            this.Lb_ExportFile.TabIndex = 8;
            this.Lb_ExportFile.Text = "输出文件";
            // 
            // Tb_OutputPath
            // 
            this.Tb_OutputPath.Location = new System.Drawing.Point(136, 586);
            this.Tb_OutputPath.Name = "Tb_OutputPath";
            this.Tb_OutputPath.Size = new System.Drawing.Size(415, 28);
            this.Tb_OutputPath.TabIndex = 9;
            // 
            // Bn_SaveAs
            // 
            this.Bn_SaveAs.Location = new System.Drawing.Point(577, 586);
            this.Bn_SaveAs.Name = "Bn_SaveAs";
            this.Bn_SaveAs.Size = new System.Drawing.Size(91, 28);
            this.Bn_SaveAs.TabIndex = 11;
            this.Bn_SaveAs.Text = "...";
            this.Bn_SaveAs.UseVisualStyleBackColor = true;
            this.Bn_SaveAs.Click += new System.EventHandler(this.Bn_SaveAs_Click);
            // 
            // MyIODATA_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 692);
            this.Controls.Add(this.Bn_SaveAs);
            this.Controls.Add(this.Tb_OutputPath);
            this.Controls.Add(this.Lb_ExportFile);
            this.Controls.Add(this.Bn_Excecute);
            this.Controls.Add(this.Gb_ParamSetting);
            this.Controls.Add(this.Gb_BandSelect);
            this.Controls.Add(this.Lb_InputFile);
            this.Controls.Add(this.Bn_ChooseFile);
            this.Controls.Add(this.Tb_InputFile);
            this.Name = "MyIODATA_FRM";
            this.Text = "MyIODATA_FRM";
            this.Gb_BandSelect.ResumeLayout(false);
            this.Gb_BandSelect.PerformLayout();
            this.Gb_ParamSetting.ResumeLayout(false);
            this.Gb_ParamSetting.PerformLayout();
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
        private System.Windows.Forms.TextBox Tb_MaxIteraNum;
        private System.Windows.Forms.TextBox Tb_MinPixelNum;
        private System.Windows.Forms.TextBox Tb_InitCateNum;
        private System.Windows.Forms.TextBox Tb_PreCateNum;
        private System.Windows.Forms.Label Lb_MaxComCpNum;
        private System.Windows.Forms.Label Lb_MinCenDistance;
        private System.Windows.Forms.Label Lb_MaxSD;
        private System.Windows.Forms.Label Lb_MaxIteraNum;
        private System.Windows.Forms.Label Lb_MinPixelNum;
        private System.Windows.Forms.Label Lb_InitCateNum;
        private System.Windows.Forms.Label Lb_PreCateNum;
        private System.Windows.Forms.TextBox Tb_MaxComCpNum;
        private System.Windows.Forms.TextBox Tb_MinCenDistance;
        private System.Windows.Forms.TextBox Tb_MaxSD;
        private System.Windows.Forms.Button Bn_Excecute;
        private System.Windows.Forms.Label Lb_ExportFile;
        private System.Windows.Forms.TextBox Tb_OutputPath;
        private System.Windows.Forms.Button Bn_SaveAs;
    }
}