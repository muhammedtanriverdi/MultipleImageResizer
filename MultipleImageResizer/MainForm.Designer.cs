namespace MultipleImageResizer
{
    partial class MainForm
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
            this.fbdSelectImageFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.gbExportOptions = new System.Windows.Forms.GroupBox();
            this.cbMaintainAspectRatio = new System.Windows.Forms.CheckBox();
            this.pbExportFiles = new System.Windows.Forms.ProgressBar();
            this.btnExportFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.bwExportFiles = new System.ComponentModel.BackgroundWorker();
            this.rtbSelectedFolder = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfolder = new System.Windows.Forms.TextBox();
            this.gbExportOptions.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(13, 13);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(260, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(46, 50);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(42, 20);
            this.tbWidth.TabIndex = 1;
            this.tbWidth.Text = "100";
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(46, 79);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(42, 20);
            this.tbHeight.TabIndex = 2;
            this.tbHeight.Text = "100";
            this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbExportOptions
            // 
            this.gbExportOptions.Controls.Add(this.tbfolder);
            this.gbExportOptions.Controls.Add(this.label3);
            this.gbExportOptions.Controls.Add(this.cbMaintainAspectRatio);
            this.gbExportOptions.Controls.Add(this.pbExportFiles);
            this.gbExportOptions.Controls.Add(this.btnExportFiles);
            this.gbExportOptions.Controls.Add(this.label2);
            this.gbExportOptions.Controls.Add(this.label1);
            this.gbExportOptions.Controls.Add(this.tbWidth);
            this.gbExportOptions.Controls.Add(this.tbHeight);
            this.gbExportOptions.Enabled = false;
            this.gbExportOptions.Location = new System.Drawing.Point(13, 119);
            this.gbExportOptions.Name = "gbExportOptions";
            this.gbExportOptions.Size = new System.Drawing.Size(260, 198);
            this.gbExportOptions.TabIndex = 3;
            this.gbExportOptions.TabStop = false;
            this.gbExportOptions.Text = "Export";
            // 
            // cbMaintainAspectRatio
            // 
            this.cbMaintainAspectRatio.AutoSize = true;
            this.cbMaintainAspectRatio.Location = new System.Drawing.Point(7, 114);
            this.cbMaintainAspectRatio.Name = "cbMaintainAspectRatio";
            this.cbMaintainAspectRatio.Size = new System.Drawing.Size(130, 17);
            this.cbMaintainAspectRatio.TabIndex = 7;
            this.cbMaintainAspectRatio.Text = "Maintain Aspect Ratio";
            this.cbMaintainAspectRatio.UseVisualStyleBackColor = true;
            // 
            // pbExportFiles
            // 
            this.pbExportFiles.Location = new System.Drawing.Point(6, 166);
            this.pbExportFiles.Name = "pbExportFiles";
            this.pbExportFiles.Size = new System.Drawing.Size(248, 23);
            this.pbExportFiles.TabIndex = 6;
            // 
            // btnExportFiles
            // 
            this.btnExportFiles.Location = new System.Drawing.Point(7, 137);
            this.btnExportFiles.Name = "btnExportFiles";
            this.btnExportFiles.Size = new System.Drawing.Size(247, 23);
            this.btnExportFiles.TabIndex = 5;
            this.btnExportFiles.Text = "Export Files";
            this.btnExportFiles.UseVisualStyleBackColor = true;
            this.btnExportFiles.Click += new System.EventHandler(this.btnExportFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "width";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(285, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Status
            // 
            this.tssl_Status.Name = "tssl_Status";
            this.tssl_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // bwExportFiles
            // 
            this.bwExportFiles.WorkerReportsProgress = true;
            this.bwExportFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwExportFiles_DoWork);
            this.bwExportFiles.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwExportFiles_ProgressChanged);
            this.bwExportFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwExportFiles_RunWorkerCompleted);
            // 
            // rtbSelectedFolder
            // 
            this.rtbSelectedFolder.Enabled = false;
            this.rtbSelectedFolder.Location = new System.Drawing.Point(13, 42);
            this.rtbSelectedFolder.Name = "rtbSelectedFolder";
            this.rtbSelectedFolder.Size = new System.Drawing.Size(260, 44);
            this.rtbSelectedFolder.TabIndex = 6;
            this.rtbSelectedFolder.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "folder";
            // 
            // tbfolder
            // 
            this.tbfolder.Location = new System.Drawing.Point(46, 25);
            this.tbfolder.Name = "tbfolder";
            this.tbfolder.Size = new System.Drawing.Size(91, 20);
            this.tbfolder.TabIndex = 9;
            this.tbfolder.Text = "kucuk";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 351);
            this.Controls.Add(this.rtbSelectedFolder);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbExportOptions);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "MainForm";
            this.Text = "Multiple Image Resizer";
            this.gbExportOptions.ResumeLayout(false);
            this.gbExportOptions.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSelectImageFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.GroupBox gbExportOptions;
        private System.Windows.Forms.Button btnExportFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbExportFiles;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Status;
        private System.ComponentModel.BackgroundWorker bwExportFiles;
        private System.Windows.Forms.CheckBox cbMaintainAspectRatio;
        private System.Windows.Forms.RichTextBox rtbSelectedFolder;
        private System.Windows.Forms.TextBox tbfolder;
        private System.Windows.Forms.Label label3;
    }
}

