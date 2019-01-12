namespace Sparkle
{
    partial class SegClassForm
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
            this.bn_Execute = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MulSegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_LoadRuleSet = new System.Windows.Forms.Button();
            this.bn_LoadImage = new System.Windows.Forms.Button();
            this.tb_image = new System.Windows.Forms.TextBox();
            this.lb_image = new System.Windows.Forms.Label();
            this.lb_ruleset = new System.Windows.Forms.Label();
            this.tb_ruleset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_status = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Lb_result = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Pb_download = new System.Windows.Forms.ProgressBar();
            this.Bn_FTPdownload = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Lb_FTPusername = new System.Windows.Forms.Label();
            this.Lb_FTPpassword = new System.Windows.Forms.Label();
            this.Bn_SaveDownload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Download_Path = new System.Windows.Forms.TextBox();
            this.Tb_FTPusername = new System.Windows.Forms.TextBox();
            this.Tb_FTPpassword = new System.Windows.Forms.TextBox();
            this.Tb_FTPpath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Bn_SaveAllFile = new System.Windows.Forms.Button();
            this.bn_downFile2 = new System.Windows.Forms.Button();
            this.tb_filedownPath2 = new System.Windows.Forms.TextBox();
            this.lb_filedownPath2 = new System.Windows.Forms.Label();
            this.tb_fileRelatedInfo = new System.Windows.Forms.TextBox();
            this.lb_FileRelatedInfo = new System.Windows.Forms.Label();
            this.tb_FTPpath2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username2 = new System.Windows.Forms.TextBox();
            this.lb_username2 = new System.Windows.Forms.Label();
            this.lb_process = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_projectPath = new System.Windows.Forms.Label();
            this.tb_projectPath = new System.Windows.Forms.TextBox();
            this.bn_SaveProj = new System.Windows.Forms.Button();
            this.lb_projectName = new System.Windows.Forms.Label();
            this.tb_projetName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_Execute
            // 
            this.bn_Execute.Location = new System.Drawing.Point(296, 563);
            this.bn_Execute.Name = "bn_Execute";
            this.bn_Execute.Size = new System.Drawing.Size(104, 37);
            this.bn_Execute.TabIndex = 1;
            this.bn_Execute.Text = "执行算法";
            this.bn_Execute.UseVisualStyleBackColor = true;
            this.bn_Execute.Click += new System.EventHandler(this.bn_Execute_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MulSegToolStripMenuItem,
            this.ClassSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MulSegToolStripMenuItem
            // 
            this.MulSegToolStripMenuItem.Name = "MulSegToolStripMenuItem";
            this.MulSegToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.MulSegToolStripMenuItem.Text = "多尺度分割参数设置";
            this.MulSegToolStripMenuItem.Click += new System.EventHandler(this.MulSegToolStripMenuItem_Click);
            // 
            // ClassSettingToolStripMenuItem
            // 
            this.ClassSettingToolStripMenuItem.Name = "ClassSettingToolStripMenuItem";
            this.ClassSettingToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.ClassSettingToolStripMenuItem.Text = "分类信息设置";
            this.ClassSettingToolStripMenuItem.Click += new System.EventHandler(this.ClassSettingToolStripMenuItem_Click);
            // 
            // bn_LoadRuleSet
            // 
            this.bn_LoadRuleSet.Location = new System.Drawing.Point(684, 423);
            this.bn_LoadRuleSet.Name = "bn_LoadRuleSet";
            this.bn_LoadRuleSet.Size = new System.Drawing.Size(146, 34);
            this.bn_LoadRuleSet.TabIndex = 3;
            this.bn_LoadRuleSet.Text = "加载规则集";
            this.bn_LoadRuleSet.UseVisualStyleBackColor = true;
            this.bn_LoadRuleSet.Click += new System.EventHandler(this.bn_LoadRuleSet_Click);
            // 
            // bn_LoadImage
            // 
            this.bn_LoadImage.Location = new System.Drawing.Point(684, 382);
            this.bn_LoadImage.Name = "bn_LoadImage";
            this.bn_LoadImage.Size = new System.Drawing.Size(146, 35);
            this.bn_LoadImage.TabIndex = 4;
            this.bn_LoadImage.Text = "加载影像";
            this.bn_LoadImage.UseVisualStyleBackColor = true;
            this.bn_LoadImage.Click += new System.EventHandler(this.bn_LoadImage_Click);
            // 
            // tb_image
            // 
            this.tb_image.Location = new System.Drawing.Point(194, 387);
            this.tb_image.Name = "tb_image";
            this.tb_image.ReadOnly = true;
            this.tb_image.Size = new System.Drawing.Size(484, 25);
            this.tb_image.TabIndex = 0;
            //this.tb_image.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_image
            // 
            this.lb_image.AutoSize = true;
            this.lb_image.Location = new System.Drawing.Point(37, 393);
            this.lb_image.Name = "lb_image";
            this.lb_image.Size = new System.Drawing.Size(82, 15);
            this.lb_image.TabIndex = 5;
            this.lb_image.Text = "影像路径：";
            // 
            // lb_ruleset
            // 
            this.lb_ruleset.AutoSize = true;
            this.lb_ruleset.Location = new System.Drawing.Point(37, 434);
            this.lb_ruleset.Name = "lb_ruleset";
            this.lb_ruleset.Size = new System.Drawing.Size(97, 15);
            this.lb_ruleset.TabIndex = 6;
            this.lb_ruleset.Text = "规则集路径：";
            // 
            // tb_ruleset
            // 
            this.tb_ruleset.Location = new System.Drawing.Point(194, 428);
            this.tb_ruleset.Name = "tb_ruleset";
            this.tb_ruleset.ReadOnly = true;
            this.tb_ruleset.Size = new System.Drawing.Size(484, 25);
            this.tb_ruleset.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 9;
            // 
            // Lb_status
            // 
            this.Lb_status.AutoSize = true;
            this.Lb_status.Location = new System.Drawing.Point(37, 571);
            this.Lb_status.Name = "Lb_status";
            this.Lb_status.Size = new System.Drawing.Size(52, 15);
            this.Lb_status.TabIndex = 10;
            this.Lb_status.Text = "状态：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Lb_result
            // 
            this.Lb_result.AutoSize = true;
            this.Lb_result.Location = new System.Drawing.Point(89, 572);
            this.Lb_result.Name = "Lb_result";
            this.Lb_result.Size = new System.Drawing.Size(0, 15);
            this.Lb_result.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(418, 564);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 35);
            this.progressBar1.TabIndex = 12;
            // 
            // Pb_download
            // 
            this.Pb_download.Location = new System.Drawing.Point(418, 345);
            this.Pb_download.Name = "Pb_download";
            this.Pb_download.Size = new System.Drawing.Size(260, 36);
            this.Pb_download.TabIndex = 10;
            // 
            // Bn_FTPdownload
            // 
            this.Bn_FTPdownload.Location = new System.Drawing.Point(199, 232);
            this.Bn_FTPdownload.Name = "Bn_FTPdownload";
            this.Bn_FTPdownload.Size = new System.Drawing.Size(104, 32);
            this.Bn_FTPdownload.TabIndex = 11;
            this.Bn_FTPdownload.Text = "开始下载";
            this.Bn_FTPdownload.UseVisualStyleBackColor = true;
            this.Bn_FTPdownload.Click += new System.EventHandler(this.Bn_FTPdownload_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 308);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lb_FTPusername);
            this.tabPage1.Controls.Add(this.Lb_FTPpassword);
            this.tabPage1.Controls.Add(this.Bn_FTPdownload);
            this.tabPage1.Controls.Add(this.Bn_SaveDownload);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Tb_Download_Path);
            this.tabPage1.Controls.Add(this.Tb_FTPusername);
            this.tabPage1.Controls.Add(this.Tb_FTPpassword);
            this.tabPage1.Controls.Add(this.Tb_FTPpath);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "从FTP服务器中逐个下载文件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lb_FTPusername
            // 
            this.Lb_FTPusername.AutoSize = true;
            this.Lb_FTPusername.Location = new System.Drawing.Point(33, 27);
            this.Lb_FTPusername.Name = "Lb_FTPusername";
            this.Lb_FTPusername.Size = new System.Drawing.Size(67, 15);
            this.Lb_FTPusername.TabIndex = 0;
            this.Lb_FTPusername.Text = "用户名：";
            // 
            // Lb_FTPpassword
            // 
            this.Lb_FTPpassword.AutoSize = true;
            this.Lb_FTPpassword.Location = new System.Drawing.Point(33, 70);
            this.Lb_FTPpassword.Name = "Lb_FTPpassword";
            this.Lb_FTPpassword.Size = new System.Drawing.Size(52, 15);
            this.Lb_FTPpassword.TabIndex = 1;
            this.Lb_FTPpassword.Text = "密码：";
            // 
            // Bn_SaveDownload
            // 
            this.Bn_SaveDownload.Location = new System.Drawing.Point(680, 154);
            this.Bn_SaveDownload.Name = "Bn_SaveDownload";
            this.Bn_SaveDownload.Size = new System.Drawing.Size(104, 34);
            this.Bn_SaveDownload.TabIndex = 6;
            this.Bn_SaveDownload.Text = "...";
            this.Bn_SaveDownload.UseVisualStyleBackColor = true;
            this.Bn_SaveDownload.Click += new System.EventHandler(this.Bn_SaveDownload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "将文件下载到：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "FTP路径：";
            // 
            // Tb_Download_Path
            // 
            this.Tb_Download_Path.Location = new System.Drawing.Point(190, 158);
            this.Tb_Download_Path.Name = "Tb_Download_Path";
            this.Tb_Download_Path.ReadOnly = true;
            this.Tb_Download_Path.Size = new System.Drawing.Size(484, 25);
            this.Tb_Download_Path.TabIndex = 9;
            // 
            // Tb_FTPusername
            // 
            this.Tb_FTPusername.Location = new System.Drawing.Point(190, 17);
            this.Tb_FTPusername.Name = "Tb_FTPusername";
            this.Tb_FTPusername.Size = new System.Drawing.Size(484, 25);
            this.Tb_FTPusername.TabIndex = 3;
            // 
            // Tb_FTPpassword
            // 
            this.Tb_FTPpassword.Location = new System.Drawing.Point(190, 60);
            this.Tb_FTPpassword.Name = "Tb_FTPpassword";
            this.Tb_FTPpassword.Size = new System.Drawing.Size(484, 25);
            this.Tb_FTPpassword.TabIndex = 4;
            // 
            // Tb_FTPpath
            // 
            this.Tb_FTPpath.Location = new System.Drawing.Point(190, 111);
            this.Tb_FTPpath.Name = "Tb_FTPpath";
            this.Tb_FTPpath.Size = new System.Drawing.Size(484, 25);
            this.Tb_FTPpath.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Bn_SaveAllFile);
            this.tabPage2.Controls.Add(this.bn_downFile2);
            this.tabPage2.Controls.Add(this.tb_filedownPath2);
            this.tabPage2.Controls.Add(this.lb_filedownPath2);
            this.tabPage2.Controls.Add(this.tb_fileRelatedInfo);
            this.tabPage2.Controls.Add(this.lb_FileRelatedInfo);
            this.tabPage2.Controls.Add(this.tb_FTPpath2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_password2);
            this.tabPage2.Controls.Add(this.lb_password);
            this.tabPage2.Controls.Add(this.tb_username2);
            this.tabPage2.Controls.Add(this.lb_username2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "从FTP服务器中下载全部相关文件";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Bn_SaveAllFile
            // 
            this.Bn_SaveAllFile.Location = new System.Drawing.Point(681, 190);
            this.Bn_SaveAllFile.Name = "Bn_SaveAllFile";
            this.Bn_SaveAllFile.Size = new System.Drawing.Size(103, 31);
            this.Bn_SaveAllFile.TabIndex = 12;
            this.Bn_SaveAllFile.Text = "...";
            this.Bn_SaveAllFile.UseVisualStyleBackColor = true;
            this.Bn_SaveAllFile.Click += new System.EventHandler(this.Bn_SaveAllFile_Click);
            // 
            // bn_downFile2
            // 
            this.bn_downFile2.Location = new System.Drawing.Point(199, 238);
            this.bn_downFile2.Name = "bn_downFile2";
            this.bn_downFile2.Size = new System.Drawing.Size(104, 35);
            this.bn_downFile2.TabIndex = 11;
            this.bn_downFile2.Text = "开始下载";
            this.bn_downFile2.UseVisualStyleBackColor = true;
            this.bn_downFile2.Click += new System.EventHandler(this.bn_downFile2_Click);
            // 
            // tb_filedownPath2
            // 
            this.tb_filedownPath2.Location = new System.Drawing.Point(190, 194);
            this.tb_filedownPath2.Name = "tb_filedownPath2";
            this.tb_filedownPath2.ReadOnly = true;
            this.tb_filedownPath2.Size = new System.Drawing.Size(484, 25);
            this.tb_filedownPath2.TabIndex = 9;
            // 
            // lb_filedownPath2
            // 
            this.lb_filedownPath2.AutoSize = true;
            this.lb_filedownPath2.Location = new System.Drawing.Point(18, 194);
            this.lb_filedownPath2.Name = "lb_filedownPath2";
            this.lb_filedownPath2.Size = new System.Drawing.Size(142, 15);
            this.lb_filedownPath2.TabIndex = 8;
            this.lb_filedownPath2.Text = "将所有文件下载到：";
            // 
            // tb_fileRelatedInfo
            // 
            this.tb_fileRelatedInfo.Location = new System.Drawing.Point(190, 152);
            this.tb_fileRelatedInfo.Name = "tb_fileRelatedInfo";
            this.tb_fileRelatedInfo.Size = new System.Drawing.Size(484, 25);
            this.tb_fileRelatedInfo.TabIndex = 7;
            // 
            // lb_FileRelatedInfo
            // 
            this.lb_FileRelatedInfo.AutoSize = true;
            this.lb_FileRelatedInfo.Location = new System.Drawing.Point(18, 155);
            this.lb_FileRelatedInfo.Name = "lb_FileRelatedInfo";
            this.lb_FileRelatedInfo.Size = new System.Drawing.Size(82, 15);
            this.lb_FileRelatedInfo.TabIndex = 6;
            this.lb_FileRelatedInfo.Text = "下载区域：";
            // 
            // tb_FTPpath2
            // 
            this.tb_FTPpath2.Location = new System.Drawing.Point(190, 107);
            this.tb_FTPpath2.Name = "tb_FTPpath2";
            this.tb_FTPpath2.Size = new System.Drawing.Size(484, 25);
            this.tb_FTPpath2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "FTP路径：";
            // 
            // tb_password2
            // 
            this.tb_password2.Location = new System.Drawing.Point(190, 59);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.Size = new System.Drawing.Size(484, 25);
            this.tb_password2.TabIndex = 3;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(23, 62);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(52, 15);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "密码：";
            // 
            // tb_username2
            // 
            this.tb_username2.Location = new System.Drawing.Point(190, 10);
            this.tb_username2.Name = "tb_username2";
            this.tb_username2.Size = new System.Drawing.Size(484, 25);
            this.tb_username2.TabIndex = 1;
            // 
            // lb_username2
            // 
            this.lb_username2.AutoSize = true;
            this.lb_username2.Location = new System.Drawing.Point(23, 20);
            this.lb_username2.Name = "lb_username2";
            this.lb_username2.Size = new System.Drawing.Size(67, 15);
            this.lb_username2.TabIndex = 0;
            this.lb_username2.Text = "用户名：";
            // 
            // lb_process
            // 
            this.lb_process.AutoSize = true;
            this.lb_process.Location = new System.Drawing.Point(37, 355);
            this.lb_process.Name = "lb_process";
            this.lb_process.Size = new System.Drawing.Size(67, 15);
            this.lb_process.TabIndex = 13;
            this.lb_process.Text = "下载进度";
            // 
            // lb_projectPath
            // 
            this.lb_projectPath.AutoSize = true;
            this.lb_projectPath.Location = new System.Drawing.Point(37, 474);
            this.lb_projectPath.Name = "lb_projectPath";
            this.lb_projectPath.Size = new System.Drawing.Size(112, 15);
            this.lb_projectPath.TabIndex = 15;
            this.lb_projectPath.Text = "输出项目路径：";
            // 
            // tb_projectPath
            // 
            this.tb_projectPath.Location = new System.Drawing.Point(194, 469);
            this.tb_projectPath.Name = "tb_projectPath";
            this.tb_projectPath.ReadOnly = true;
            this.tb_projectPath.Size = new System.Drawing.Size(484, 25);
            this.tb_projectPath.TabIndex = 16;
            // 
            // bn_SaveProj
            // 
            this.bn_SaveProj.Location = new System.Drawing.Point(685, 463);
            this.bn_SaveProj.Name = "bn_SaveProj";
            this.bn_SaveProj.Size = new System.Drawing.Size(145, 36);
            this.bn_SaveProj.TabIndex = 18;
            this.bn_SaveProj.Text = "将项目保存到";
            this.bn_SaveProj.UseVisualStyleBackColor = true;
            this.bn_SaveProj.Click += new System.EventHandler(this.bn_SaveProj_Click);
            // 
            // lb_projectName
            // 
            this.lb_projectName.AutoSize = true;
            this.lb_projectName.Location = new System.Drawing.Point(37, 512);
            this.lb_projectName.Name = "lb_projectName";
            this.lb_projectName.Size = new System.Drawing.Size(97, 15);
            this.lb_projectName.TabIndex = 19;
            this.lb_projectName.Text = "输出项目名：";
            // 
            // tb_projetName
            // 
            this.tb_projetName.Location = new System.Drawing.Point(194, 506);
            this.tb_projetName.Name = "tb_projetName";
            this.tb_projetName.Size = new System.Drawing.Size(484, 25);
            this.tb_projetName.TabIndex = 21;
            // 
            // SegClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 645);
            this.Controls.Add(this.tb_projetName);
            this.Controls.Add(this.lb_projectName);
            this.Controls.Add(this.bn_SaveProj);
            this.Controls.Add(this.tb_projectPath);
            this.Controls.Add(this.lb_projectPath);
            this.Controls.Add(this.lb_process);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Pb_download);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Lb_result);
            this.Controls.Add(this.Lb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ruleset);
            this.Controls.Add(this.lb_ruleset);
            this.Controls.Add(this.lb_image);
            this.Controls.Add(this.bn_LoadImage);
            this.Controls.Add(this.bn_LoadRuleSet);
            this.Controls.Add(this.bn_Execute);
            this.Controls.Add(this.tb_image);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SegClassForm";
            this.Text = "面向对象分类";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_Execute;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MulSegToolStripMenuItem;
        private System.Windows.Forms.Button bn_LoadRuleSet;
        private System.Windows.Forms.Button bn_LoadImage;
        private System.Windows.Forms.TextBox tb_image;
        private System.Windows.Forms.Label lb_image;
        private System.Windows.Forms.Label lb_ruleset;
        private System.Windows.Forms.TextBox tb_ruleset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_status;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label Lb_result;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem ClassSettingToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar Pb_download;
        private System.Windows.Forms.Button Bn_FTPdownload;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Lb_FTPusername;
        private System.Windows.Forms.Label Lb_FTPpassword;
        private System.Windows.Forms.Button Bn_SaveDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Download_Path;
        private System.Windows.Forms.TextBox Tb_FTPusername;
        private System.Windows.Forms.TextBox Tb_FTPpassword;
        private System.Windows.Forms.TextBox Tb_FTPpath;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_filedownPath2;
        private System.Windows.Forms.Label lb_filedownPath2;
        private System.Windows.Forms.TextBox tb_fileRelatedInfo;
        private System.Windows.Forms.Label lb_FileRelatedInfo;
        private System.Windows.Forms.TextBox tb_FTPpath2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username2;
        private System.Windows.Forms.Label lb_username2;
        private System.Windows.Forms.Button bn_downFile2;
        private System.Windows.Forms.Label lb_process;
        private System.Windows.Forms.Button Bn_SaveAllFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lb_projectPath;
        private System.Windows.Forms.TextBox tb_projectPath;
        private System.Windows.Forms.Button bn_SaveProj;
        private System.Windows.Forms.Label lb_projectName;
        private System.Windows.Forms.TextBox tb_projetName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

