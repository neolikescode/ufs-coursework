namespace LibraryFileManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentDirectory = new System.Windows.Forms.Label();
            this.grpFileDetails = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFileContent = new System.Windows.Forms.Label();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCheckFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnAppendFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.grpViewer = new System.Windows.Forms.GroupBox();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.pnlHeader.SuspendLayout();
            this.grpFileDetails.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(880, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Library File Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentDirectory
            // 
            this.lblCurrentDirectory.AutoEllipsis = true;
            this.lblCurrentDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.lblCurrentDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentDirectory.Location = new System.Drawing.Point(20, 72);
            this.lblCurrentDirectory.Name = "lblCurrentDirectory";
            this.lblCurrentDirectory.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblCurrentDirectory.Size = new System.Drawing.Size(840, 26);
            this.lblCurrentDirectory.TabIndex = 1;
            this.lblCurrentDirectory.Text = "Current Directory: (not set)";
            this.lblCurrentDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFileDetails
            // 
            this.grpFileDetails.Controls.Add(this.btnSave);
            this.grpFileDetails.Controls.Add(this.lblFileName);
            this.grpFileDetails.Controls.Add(this.txtFileName);
            this.grpFileDetails.Controls.Add(this.lblFilePath);
            this.grpFileDetails.Controls.Add(this.txtFilePath);
            this.grpFileDetails.Controls.Add(this.btnBrowse);
            this.grpFileDetails.Controls.Add(this.lblFileContent);
            this.grpFileDetails.Controls.Add(this.txtFileContent);
            this.grpFileDetails.Location = new System.Drawing.Point(20, 108);
            this.grpFileDetails.Name = "grpFileDetails";
            this.grpFileDetails.Size = new System.Drawing.Size(520, 255);
            this.grpFileDetails.TabIndex = 2;
            this.grpFileDetails.TabStop = false;
            this.grpFileDetails.Text = "File Details";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(15, 28);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(63, 15);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(15, 48);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(490, 23);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(15, 82);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(55, 15);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(15, 112);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(395, 23);
            this.txtFilePath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(420, 93);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(85, 27);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFileContent
            // 
            this.lblFileContent.AutoSize = true;
            this.lblFileContent.Location = new System.Drawing.Point(15, 138);
            this.lblFileContent.Name = "lblFileContent";
            this.lblFileContent.Size = new System.Drawing.Size(74, 15);
            this.lblFileContent.TabIndex = 5;
            this.lblFileContent.Text = "File Content:";
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(15, 158);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileContent.Size = new System.Drawing.Size(490, 82);
            this.txtFileContent.TabIndex = 6;
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.lstFiles);
            this.grpFiles.Location = new System.Drawing.Point(555, 108);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(305, 255);
            this.grpFiles.TabIndex = 3;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files in Directory";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 15;
            this.lstFiles.Location = new System.Drawing.Point(15, 25);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(275, 214);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnCreateFile);
            this.grpActions.Controls.Add(this.btnCheckFile);
            this.grpActions.Controls.Add(this.btnReadFile);
            this.grpActions.Controls.Add(this.btnWriteFile);
            this.grpActions.Controls.Add(this.btnAppendFile);
            this.grpActions.Controls.Add(this.btnDeleteFile);
            this.grpActions.Controls.Add(this.btnCreateDirectory);
            this.grpActions.Location = new System.Drawing.Point(20, 372);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(840, 72);
            this.grpActions.TabIndex = 4;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "File Operations";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(15, 25);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(105, 35);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCheckFile
            // 
            this.btnCheckFile.Location = new System.Drawing.Point(128, 25);
            this.btnCheckFile.Name = "btnCheckFile";
            this.btnCheckFile.Size = new System.Drawing.Size(105, 35);
            this.btnCheckFile.TabIndex = 1;
            this.btnCheckFile.Text = "Check File";
            this.btnCheckFile.UseVisualStyleBackColor = true;
            this.btnCheckFile.Click += new System.EventHandler(this.btnCheckFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(241, 25);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(105, 35);
            this.btnReadFile.TabIndex = 2;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(354, 25);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(105, 35);
            this.btnWriteFile.TabIndex = 3;
            this.btnWriteFile.Text = "Write File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnAppendFile
            // 
            this.btnAppendFile.Location = new System.Drawing.Point(467, 25);
            this.btnAppendFile.Name = "btnAppendFile";
            this.btnAppendFile.Size = new System.Drawing.Size(105, 35);
            this.btnAppendFile.TabIndex = 4;
            this.btnAppendFile.Text = "Append File";
            this.btnAppendFile.UseVisualStyleBackColor = true;
            this.btnAppendFile.Click += new System.EventHandler(this.btnAppendFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(580, 25);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(105, 35);
            this.btnDeleteFile.TabIndex = 5;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(693, 25);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(132, 35);
            this.btnCreateDirectory.TabIndex = 6;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // grpViewer
            // 
            this.grpViewer.Controls.Add(this.rtbFileContent);
            this.grpViewer.Location = new System.Drawing.Point(20, 454);
            this.grpViewer.Name = "grpViewer";
            this.grpViewer.Size = new System.Drawing.Size(840, 186);
            this.grpViewer.TabIndex = 5;
            this.grpViewer.TabStop = false;
            this.grpViewer.Text = "File Viewer";
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(15, 25);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(810, 146);
            this.rtbFileContent.TabIndex = 0;
            this.rtbFileContent.Text = "";
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "dlgOpen";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "dlgSave";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.Controls.Add(this.grpViewer);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.grpFileDetails);
            this.Controls.Add(this.lblCurrentDirectory);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Management";
            this.pnlHeader.ResumeLayout(false);
            this.grpFileDetails.ResumeLayout(false);
            this.grpFileDetails.PerformLayout();
            this.grpFiles.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.grpViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentDirectory;
        private System.Windows.Forms.GroupBox grpFileDetails;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCheckFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnAppendFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.GroupBox grpViewer;
        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}
