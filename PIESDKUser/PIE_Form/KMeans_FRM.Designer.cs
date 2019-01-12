namespace PIESDKUser
{
    partial class Form_KMeans
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
            this.lb_inputFile = new System.Windows.Forms.Label();
            this.tb_InputFile = new System.Windows.Forms.TextBox();
            this.bn_InputFile = new System.Windows.Forms.Button();
            this.gb_bandChoose = new System.Windows.Forms.GroupBox();
            this.bn_ClearBand = new System.Windows.Forms.Button();
            this.lb_SelectedBandNum = new System.Windows.Forms.Label();
            this.lb_BandChoose = new System.Windows.Forms.ListBox();
            this.gb_ParamSet = new System.Windows.Forms.GroupBox();
            this.tb_KillThres = new System.Windows.Forms.TextBox();
            this.lb_Tips = new System.Windows.Forms.Label();
            this.lb_KillThres = new System.Windows.Forms.Label();
            this.nud_MaxIterNums = new System.Windows.Forms.NumericUpDown();
            this.lb_MaxIterNums = new System.Windows.Forms.Label();
            this.nud_ClassNums = new System.Windows.Forms.NumericUpDown();
            this.lb_ClassNum = new System.Windows.Forms.Label();
            this.lb_outFile = new System.Windows.Forms.Label();
            this.tb_outFile = new System.Windows.Forms.TextBox();
            this.bn_OutFile = new System.Windows.Forms.Button();
            this.bn_OK = new System.Windows.Forms.Button();
            this.bn_Cancel = new System.Windows.Forms.Button();
            this.gb_bandChoose.SuspendLayout();
            this.gb_ParamSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxIterNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ClassNums)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_inputFile
            // 
            this.lb_inputFile.AutoSize = true;
            this.lb_inputFile.Location = new System.Drawing.Point(23, 27);
            this.lb_inputFile.Name = "lb_inputFile";
            this.lb_inputFile.Size = new System.Drawing.Size(67, 15);
            this.lb_inputFile.TabIndex = 0;
            this.lb_inputFile.Text = "输入文件";
            // 
            // tb_InputFile
            // 
            this.tb_InputFile.Location = new System.Drawing.Point(122, 22);
            this.tb_InputFile.Name = "tb_InputFile";
            this.tb_InputFile.Size = new System.Drawing.Size(339, 25);
            this.tb_InputFile.TabIndex = 1;
            // 
            // bn_InputFile
            // 
            this.bn_InputFile.Location = new System.Drawing.Point(492, 19);
            this.bn_InputFile.Name = "bn_InputFile";
            this.bn_InputFile.Size = new System.Drawing.Size(90, 31);
            this.bn_InputFile.TabIndex = 2;
            this.bn_InputFile.Text = "...";
            this.bn_InputFile.UseVisualStyleBackColor = true;
            this.bn_InputFile.Click += new System.EventHandler(this.bn_InputFile_Click);
            // 
            // gb_bandChoose
            // 
            this.gb_bandChoose.Controls.Add(this.bn_ClearBand);
            this.gb_bandChoose.Controls.Add(this.lb_SelectedBandNum);
            this.gb_bandChoose.Controls.Add(this.lb_BandChoose);
            this.gb_bandChoose.Location = new System.Drawing.Point(26, 92);
            this.gb_bandChoose.Name = "gb_bandChoose";
            this.gb_bandChoose.Size = new System.Drawing.Size(282, 294);
            this.gb_bandChoose.TabIndex = 3;
            this.gb_bandChoose.TabStop = false;
            this.gb_bandChoose.Text = "波段选择";
            // 
            // bn_ClearBand
            // 
            this.bn_ClearBand.Location = new System.Drawing.Point(181, 243);
            this.bn_ClearBand.Name = "bn_ClearBand";
            this.bn_ClearBand.Size = new System.Drawing.Size(75, 31);
            this.bn_ClearBand.TabIndex = 2;
            this.bn_ClearBand.Text = "全选";
            this.bn_ClearBand.UseVisualStyleBackColor = true;
            this.bn_ClearBand.Click += new System.EventHandler(this.bn_ClearBand_Click);
            // 
            // lb_SelectedBandNum
            // 
            this.lb_SelectedBandNum.AutoSize = true;
            this.lb_SelectedBandNum.Location = new System.Drawing.Point(9, 251);
            this.lb_SelectedBandNum.Name = "lb_SelectedBandNum";
            this.lb_SelectedBandNum.Size = new System.Drawing.Size(0, 15);
            this.lb_SelectedBandNum.TabIndex = 1;
            // 
            // lb_BandChoose
            // 
            this.lb_BandChoose.FormattingEnabled = true;
            this.lb_BandChoose.ItemHeight = 15;
            this.lb_BandChoose.Location = new System.Drawing.Point(6, 20);
            this.lb_BandChoose.Name = "lb_BandChoose";
            this.lb_BandChoose.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_BandChoose.Size = new System.Drawing.Size(270, 259);
            this.lb_BandChoose.TabIndex = 0;
            this.lb_BandChoose.SelectedIndexChanged += new System.EventHandler(this.lb_BandChoose_SelectedIndexChanged);
            // 
            // gb_ParamSet
            // 
            this.gb_ParamSet.Controls.Add(this.tb_KillThres);
            this.gb_ParamSet.Controls.Add(this.lb_Tips);
            this.gb_ParamSet.Controls.Add(this.lb_KillThres);
            this.gb_ParamSet.Controls.Add(this.nud_MaxIterNums);
            this.gb_ParamSet.Controls.Add(this.lb_MaxIterNums);
            this.gb_ParamSet.Controls.Add(this.nud_ClassNums);
            this.gb_ParamSet.Controls.Add(this.lb_ClassNum);
            this.gb_ParamSet.Location = new System.Drawing.Point(314, 92);
            this.gb_ParamSet.Name = "gb_ParamSet";
            this.gb_ParamSet.Size = new System.Drawing.Size(288, 294);
            this.gb_ParamSet.TabIndex = 4;
            this.gb_ParamSet.TabStop = false;
            this.gb_ParamSet.Text = "参数设置";
            // 
            // tb_KillThres
            // 
            this.tb_KillThres.Location = new System.Drawing.Point(159, 153);
            this.tb_KillThres.Name = "tb_KillThres";
            this.tb_KillThres.Size = new System.Drawing.Size(53, 25);
            this.tb_KillThres.TabIndex = 6;
            // 
            // lb_Tips
            // 
            this.lb_Tips.AutoSize = true;
            this.lb_Tips.Location = new System.Drawing.Point(219, 158);
            this.lb_Tips.Name = "lb_Tips";
            this.lb_Tips.Size = new System.Drawing.Size(54, 15);
            this.lb_Tips.TabIndex = 5;
            this.lb_Tips.Text = "(0-1）";
            // 
            // lb_KillThres
            // 
            this.lb_KillThres.AutoSize = true;
            this.lb_KillThres.Location = new System.Drawing.Point(10, 156);
            this.lb_KillThres.Name = "lb_KillThres";
            this.lb_KillThres.Size = new System.Drawing.Size(75, 15);
            this.lb_KillThres.TabIndex = 4;
            this.lb_KillThres.Text = "终止阈值:";
            // 
            // nud_MaxIterNums
            // 
            this.nud_MaxIterNums.Location = new System.Drawing.Point(159, 87);
            this.nud_MaxIterNums.Name = "nud_MaxIterNums";
            this.nud_MaxIterNums.Size = new System.Drawing.Size(53, 25);
            this.nud_MaxIterNums.TabIndex = 3;
            this.nud_MaxIterNums.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_MaxIterNums
            // 
            this.lb_MaxIterNums.AutoSize = true;
            this.lb_MaxIterNums.Location = new System.Drawing.Point(7, 89);
            this.lb_MaxIterNums.Name = "lb_MaxIterNums";
            this.lb_MaxIterNums.Size = new System.Drawing.Size(112, 15);
            this.lb_MaxIterNums.TabIndex = 2;
            this.lb_MaxIterNums.Text = "最大迭代次数：";
            // 
            // nud_ClassNums
            // 
            this.nud_ClassNums.Location = new System.Drawing.Point(159, 25);
            this.nud_ClassNums.Name = "nud_ClassNums";
            this.nud_ClassNums.Size = new System.Drawing.Size(53, 25);
            this.nud_ClassNums.TabIndex = 1;
            this.nud_ClassNums.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lb_ClassNum
            // 
            this.lb_ClassNum.AutoSize = true;
            this.lb_ClassNum.Location = new System.Drawing.Point(7, 35);
            this.lb_ClassNum.Name = "lb_ClassNum";
            this.lb_ClassNum.Size = new System.Drawing.Size(82, 15);
            this.lb_ClassNum.TabIndex = 0;
            this.lb_ClassNum.Text = "预期类数：";
            // 
            // lb_outFile
            // 
            this.lb_outFile.AutoSize = true;
            this.lb_outFile.Location = new System.Drawing.Point(29, 432);
            this.lb_outFile.Name = "lb_outFile";
            this.lb_outFile.Size = new System.Drawing.Size(67, 15);
            this.lb_outFile.TabIndex = 5;
            this.lb_outFile.Text = "输出文件";
            // 
            // tb_outFile
            // 
            this.tb_outFile.Location = new System.Drawing.Point(122, 429);
            this.tb_outFile.Name = "tb_outFile";
            this.tb_outFile.Size = new System.Drawing.Size(339, 25);
            this.tb_outFile.TabIndex = 6;
            // 
            // bn_OutFile
            // 
            this.bn_OutFile.Location = new System.Drawing.Point(497, 424);
            this.bn_OutFile.Name = "bn_OutFile";
            this.bn_OutFile.Size = new System.Drawing.Size(90, 34);
            this.bn_OutFile.TabIndex = 7;
            this.bn_OutFile.Text = "...";
            this.bn_OutFile.UseVisualStyleBackColor = true;
            this.bn_OutFile.Click += new System.EventHandler(this.bn_OutFile_Click);
            // 
            // bn_OK
            // 
            this.bn_OK.Location = new System.Drawing.Point(38, 540);
            this.bn_OK.Name = "bn_OK";
            this.bn_OK.Size = new System.Drawing.Size(75, 31);
            this.bn_OK.TabIndex = 8;
            this.bn_OK.Text = "确定";
            this.bn_OK.UseVisualStyleBackColor = true;
            this.bn_OK.Click += new System.EventHandler(this.bn_OK_Click);
            // 
            // bn_Cancel
            // 
            this.bn_Cancel.Location = new System.Drawing.Point(473, 540);
            this.bn_Cancel.Name = "bn_Cancel";
            this.bn_Cancel.Size = new System.Drawing.Size(90, 31);
            this.bn_Cancel.TabIndex = 9;
            this.bn_Cancel.Text = "取消";
            this.bn_Cancel.UseVisualStyleBackColor = true;
            this.bn_Cancel.Click += new System.EventHandler(this.bn_Cancel_Click);
            // 
            // Form_KMeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 619);
            this.Controls.Add(this.bn_Cancel);
            this.Controls.Add(this.bn_OK);
            this.Controls.Add(this.bn_OutFile);
            this.Controls.Add(this.tb_outFile);
            this.Controls.Add(this.lb_outFile);
            this.Controls.Add(this.gb_ParamSet);
            this.Controls.Add(this.gb_bandChoose);
            this.Controls.Add(this.bn_InputFile);
            this.Controls.Add(this.tb_InputFile);
            this.Controls.Add(this.lb_inputFile);
            this.Name = "Form_KMeans";
            this.Text = "KMeans";
            this.gb_bandChoose.ResumeLayout(false);
            this.gb_bandChoose.PerformLayout();
            this.gb_ParamSet.ResumeLayout(false);
            this.gb_ParamSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxIterNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ClassNums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_inputFile;
        private System.Windows.Forms.TextBox tb_InputFile;
        private System.Windows.Forms.Button bn_InputFile;
        private System.Windows.Forms.GroupBox gb_bandChoose;
        private System.Windows.Forms.Button bn_ClearBand;
        private System.Windows.Forms.Label lb_SelectedBandNum;
        private System.Windows.Forms.ListBox lb_BandChoose;
        private System.Windows.Forms.GroupBox gb_ParamSet;
        private System.Windows.Forms.TextBox tb_KillThres;
        private System.Windows.Forms.Label lb_Tips;
        private System.Windows.Forms.Label lb_KillThres;
        private System.Windows.Forms.NumericUpDown nud_MaxIterNums;
        private System.Windows.Forms.Label lb_MaxIterNums;
        private System.Windows.Forms.NumericUpDown nud_ClassNums;
        private System.Windows.Forms.Label lb_ClassNum;
        private System.Windows.Forms.Label lb_outFile;
        private System.Windows.Forms.TextBox tb_outFile;
        private System.Windows.Forms.Button bn_OutFile;
        private System.Windows.Forms.Button bn_OK;
        private System.Windows.Forms.Button bn_Cancel;
    }
}