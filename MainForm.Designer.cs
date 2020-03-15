namespace Prosource_Extracting_PDF
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
            this.gBoxSelectedZipFiles = new System.Windows.Forms.GroupBox();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.gBoxSourceAndDestinationPath = new System.Windows.Forms.GroupBox();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.btnDestinationPath = new System.Windows.Forms.Button();
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gBoxLog = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listLog = new System.Windows.Forms.ListBox();
            this.gBoxSelectedZipFiles.SuspendLayout();
            this.gBoxSourceAndDestinationPath.SuspendLayout();
            this.gBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSelectedZipFiles
            // 
            this.gBoxSelectedZipFiles.Controls.Add(this.listFiles);
            this.gBoxSelectedZipFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxSelectedZipFiles.Location = new System.Drawing.Point(0, 0);
            this.gBoxSelectedZipFiles.Name = "gBoxSelectedZipFiles";
            this.gBoxSelectedZipFiles.Size = new System.Drawing.Size(292, 387);
            this.gBoxSelectedZipFiles.TabIndex = 0;
            this.gBoxSelectedZipFiles.TabStop = false;
            this.gBoxSelectedZipFiles.Text = "Files";
            // 
            // listFiles
            // 
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 18;
            this.listFiles.Location = new System.Drawing.Point(3, 20);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(286, 364);
            this.listFiles.TabIndex = 0;
            // 
            // gBoxSourceAndDestinationPath
            // 
            this.gBoxSourceAndDestinationPath.Controls.Add(this.lblDestinationPath);
            this.gBoxSourceAndDestinationPath.Controls.Add(this.lblSourcePath);
            this.gBoxSourceAndDestinationPath.Controls.Add(this.btnDestinationPath);
            this.gBoxSourceAndDestinationPath.Controls.Add(this.btnSourcePath);
            this.gBoxSourceAndDestinationPath.Controls.Add(this.btnStart);
            this.gBoxSourceAndDestinationPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxSourceAndDestinationPath.Location = new System.Drawing.Point(0, 0);
            this.gBoxSourceAndDestinationPath.Name = "gBoxSourceAndDestinationPath";
            this.gBoxSourceAndDestinationPath.Size = new System.Drawing.Size(1087, 119);
            this.gBoxSourceAndDestinationPath.TabIndex = 1;
            this.gBoxSourceAndDestinationPath.TabStop = false;
            this.gBoxSourceAndDestinationPath.Text = "Zip files source and destination path";
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDestinationPath.Location = new System.Drawing.Point(218, 79);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(116, 18);
            this.lblDestinationPath.TabIndex = 2;
            this.lblDestinationPath.Text = "Destination Path";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSourcePath.Location = new System.Drawing.Point(218, 34);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(90, 18);
            this.lblSourcePath.TabIndex = 2;
            this.lblSourcePath.Text = "Source Path";
            // 
            // btnDestinationPath
            // 
            this.btnDestinationPath.Location = new System.Drawing.Point(17, 69);
            this.btnDestinationPath.Name = "btnDestinationPath";
            this.btnDestinationPath.Size = new System.Drawing.Size(195, 38);
            this.btnDestinationPath.TabIndex = 1;
            this.btnDestinationPath.Text = "Select Destination Path";
            this.btnDestinationPath.UseVisualStyleBackColor = true;
            this.btnDestinationPath.Click += new System.EventHandler(this.btnDestinationPath_Click);
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.Location = new System.Drawing.Point(17, 24);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(195, 38);
            this.btnSourcePath.TabIndex = 1;
            this.btnSourcePath.Text = "Select Source Path";
            this.btnSourcePath.UseVisualStyleBackColor = true;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(939, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 62);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gBoxLog
            // 
            this.gBoxLog.Controls.Add(this.listLog);
            this.gBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxLog.Location = new System.Drawing.Point(0, 0);
            this.gBoxLog.Name = "gBoxLog";
            this.gBoxLog.Size = new System.Drawing.Size(791, 387);
            this.gBoxLog.TabIndex = 2;
            this.gBoxLog.TabStop = false;
            this.gBoxLog.Text = "Log";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 119);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gBoxSelectedZipFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gBoxLog);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 387);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 3;
            // 
            // listLog
            // 
            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 18;
            this.listLog.Location = new System.Drawing.Point(3, 20);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(785, 364);
            this.listLog.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 506);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gBoxSourceAndDestinationPath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prosource Extracting PDF files";
            this.gBoxSelectedZipFiles.ResumeLayout(false);
            this.gBoxSourceAndDestinationPath.ResumeLayout(false);
            this.gBoxSourceAndDestinationPath.PerformLayout();
            this.gBoxLog.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSelectedZipFiles;
        private System.Windows.Forms.GroupBox gBoxSourceAndDestinationPath;
        private System.Windows.Forms.GroupBox gBoxLog;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Button btnDestinationPath;
        private System.Windows.Forms.Label lblDestinationPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listLog;
    }
}

