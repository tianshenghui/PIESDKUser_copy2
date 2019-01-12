namespace Sparkle
{
    partial class SegSetting
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bn_SaveAs = new System.Windows.Forms.Button();
            this.tb_outpath = new System.Windows.Forms.TextBox();
            this.Lb_outpath = new System.Windows.Forms.Label();
            this.lb_Compact = new System.Windows.Forms.Label();
            this.lb_Shape = new System.Windows.Forms.Label();
            this.txt_compactness = new System.Windows.Forms.TextBox();
            this.txt_shape = new System.Windows.Forms.TextBox();
            this.txt_scale = new System.Windows.Forms.TextBox();
            this.lb_Scale = new System.Windows.Forms.Label();
            this.btn_execute = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bn_SaveAs);
            this.groupBox1.Controls.Add(this.tb_outpath);
            this.groupBox1.Controls.Add(this.Lb_outpath);
            this.groupBox1.Controls.Add(this.lb_Compact);
            this.groupBox1.Controls.Add(this.lb_Shape);
            this.groupBox1.Controls.Add(this.txt_compactness);
            this.groupBox1.Controls.Add(this.txt_shape);
            this.groupBox1.Controls.Add(this.txt_scale);
            this.groupBox1.Controls.Add(this.lb_Scale);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(507, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "算法参数";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bn_SaveAs
            // 
            this.bn_SaveAs.Location = new System.Drawing.Point(408, 198);
            this.bn_SaveAs.Name = "bn_SaveAs";
            this.bn_SaveAs.Size = new System.Drawing.Size(75, 32);
            this.bn_SaveAs.TabIndex = 8;
            this.bn_SaveAs.Text = "另存为";
            this.bn_SaveAs.UseVisualStyleBackColor = true;
            this.bn_SaveAs.Click += new System.EventHandler(this.bn_SaveAs_Click);
            // 
            // tb_outpath
            // 
            this.tb_outpath.Location = new System.Drawing.Point(167, 202);
            this.tb_outpath.Name = "tb_outpath";
            this.tb_outpath.Size = new System.Drawing.Size(222, 25);
            this.tb_outpath.TabIndex = 7;
            // 
            // Lb_outpath
            // 
            this.Lb_outpath.AutoSize = true;
            this.Lb_outpath.Location = new System.Drawing.Point(32, 208);
            this.Lb_outpath.Name = "Lb_outpath";
            this.Lb_outpath.Size = new System.Drawing.Size(67, 15);
            this.Lb_outpath.TabIndex = 6;
            this.Lb_outpath.Text = "输出路径";
            // 
            // lb_Compact
            // 
            this.lb_Compact.AutoSize = true;
            this.lb_Compact.Location = new System.Drawing.Point(32, 153);
            this.lb_Compact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Compact.Name = "lb_Compact";
            this.lb_Compact.Size = new System.Drawing.Size(52, 15);
            this.lb_Compact.TabIndex = 5;
            this.lb_Compact.Text = "紧致度";
            // 
            // lb_Shape
            // 
            this.lb_Shape.AutoSize = true;
            this.lb_Shape.Location = new System.Drawing.Point(32, 101);
            this.lb_Shape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Shape.Name = "lb_Shape";
            this.lb_Shape.Size = new System.Drawing.Size(67, 15);
            this.lb_Shape.TabIndex = 4;
            this.lb_Shape.Text = "形状因子";
            // 
            // txt_compactness
            // 
            this.txt_compactness.Location = new System.Drawing.Point(167, 150);
            this.txt_compactness.Margin = new System.Windows.Forms.Padding(4);
            this.txt_compactness.Name = "txt_compactness";
            this.txt_compactness.Size = new System.Drawing.Size(222, 25);
            this.txt_compactness.TabIndex = 3;
            // 
            // txt_shape
            // 
            this.txt_shape.Location = new System.Drawing.Point(167, 98);
            this.txt_shape.Margin = new System.Windows.Forms.Padding(4);
            this.txt_shape.Name = "txt_shape";
            this.txt_shape.Size = new System.Drawing.Size(222, 25);
            this.txt_shape.TabIndex = 2;
            // 
            // txt_scale
            // 
            this.txt_scale.Location = new System.Drawing.Point(167, 42);
            this.txt_scale.Margin = new System.Windows.Forms.Padding(4);
            this.txt_scale.Name = "txt_scale";
            this.txt_scale.Size = new System.Drawing.Size(222, 25);
            this.txt_scale.TabIndex = 1;
            // 
            // lb_Scale
            // 
            this.lb_Scale.AutoSize = true;
            this.lb_Scale.Location = new System.Drawing.Point(32, 45);
            this.lb_Scale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Scale.Name = "lb_Scale";
            this.lb_Scale.Size = new System.Drawing.Size(37, 15);
            this.lb_Scale.TabIndex = 0;
            this.lb_Scale.Text = "尺度";
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(354, 280);
            this.btn_execute.Margin = new System.Windows.Forms.Padding(4);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(100, 40);
            this.btn_execute.TabIndex = 9;
            this.btn_execute.Text = "确定";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // SegSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 344);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SegSetting";
            this.Text = "多尺度分割参数设置";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Compact;
        private System.Windows.Forms.Label lb_Shape;
        private System.Windows.Forms.TextBox txt_compactness;
        private System.Windows.Forms.TextBox txt_shape;
        private System.Windows.Forms.TextBox txt_scale;
        private System.Windows.Forms.Label lb_Scale;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Button bn_SaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tb_outpath;
        private System.Windows.Forms.Label Lb_outpath;
    }
}

