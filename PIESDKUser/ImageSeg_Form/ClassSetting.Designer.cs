namespace Sparkle
{
    partial class ClassSettingForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dgvClassDetail = new System.Windows.Forms.DataGridView();
            this.Cn_ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.颜色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Lb_OutClassResult = new System.Windows.Forms.Label();
            this.tb_outputPath = new System.Windows.Forms.TextBox();
            this.Bn_SaveClassResult = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassDetail
            // 
            this.dgvClassDetail.AllowDrop = true;
            this.dgvClassDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClassDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClassDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassDetail.ColumnHeadersVisible = false;
            this.dgvClassDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cn_ClassName,
            this.颜色});
            this.dgvClassDetail.Location = new System.Drawing.Point(27, 15);
            this.dgvClassDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClassDetail.Name = "dgvClassDetail";
            this.dgvClassDetail.RowHeadersVisible = false;
            this.dgvClassDetail.RowTemplate.Height = 23;
            this.dgvClassDetail.Size = new System.Drawing.Size(423, 254);
            this.dgvClassDetail.TabIndex = 0;
            this.dgvClassDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassDetail_CellMouseClick);
            // 
            // Cn_ClassName
            // 
            this.Cn_ClassName.HeaderText = "类名";
            this.Cn_ClassName.Name = "Cn_ClassName";
            // 
            // 颜色
            // 
            this.颜色.HeaderText = "颜色";
            this.颜色.Name = "颜色";
            // 
            // color
            // 
            this.color.HeaderText = "color";
            this.color.Name = "color";
            this.color.Width = 30;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(425, 15);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(25, 254);
            this.vScrollBar1.TabIndex = 1;
            // 
            // Lb_OutClassResult
            // 
            this.Lb_OutClassResult.AutoSize = true;
            this.Lb_OutClassResult.Location = new System.Drawing.Point(24, 273);
            this.Lb_OutClassResult.Name = "Lb_OutClassResult";
            this.Lb_OutClassResult.Size = new System.Drawing.Size(112, 15);
            this.Lb_OutClassResult.TabIndex = 2;
            this.Lb_OutClassResult.Text = "输出分类结果：";
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.Location = new System.Drawing.Point(27, 304);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.ReadOnly = true;
            this.tb_outputPath.Size = new System.Drawing.Size(315, 25);
            this.tb_outputPath.TabIndex = 3;
            // 
            // Bn_SaveClassResult
            // 
            this.Bn_SaveClassResult.Location = new System.Drawing.Point(375, 299);
            this.Bn_SaveClassResult.Name = "Bn_SaveClassResult";
            this.Bn_SaveClassResult.Size = new System.Drawing.Size(75, 33);
            this.Bn_SaveClassResult.TabIndex = 4;
            this.Bn_SaveClassResult.Text = "另存为";
            this.Bn_SaveClassResult.UseVisualStyleBackColor = true;
            this.Bn_SaveClassResult.Click += new System.EventHandler(this.Bn_SaveClassResult_Click);
            // 
            // bn_OK
            // 
            this.bn_OK.Location = new System.Drawing.Point(375, 349);
            this.bn_OK.Name = "bn_OK";
            this.bn_OK.Size = new System.Drawing.Size(75, 32);
            this.bn_OK.TabIndex = 5;
            this.bn_OK.Text = "确定";
            this.bn_OK.UseVisualStyleBackColor = true;
            this.bn_OK.Click += new System.EventHandler(this.bn_OK_Click);
            // 
            // ClassSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 393);
            this.Controls.Add(this.bn_OK);
            this.Controls.Add(this.Bn_SaveClassResult);
            this.Controls.Add(this.tb_outputPath);
            this.Controls.Add(this.Lb_OutClassResult);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dgvClassDetail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClassSettingForm";
            this.Text = "分类参数设置";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dgvClassDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cn_ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 颜色;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label Lb_OutClassResult;
        private System.Windows.Forms.TextBox tb_outputPath;
        private System.Windows.Forms.Button Bn_SaveClassResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bn_OK;
    }
}

