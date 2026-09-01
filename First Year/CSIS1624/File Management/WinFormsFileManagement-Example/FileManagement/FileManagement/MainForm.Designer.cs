/*
 * Created by SharpDevelop.
 * User: Jay
 * Date: 2026/08/25
 * Time: 14:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FileManagement
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.grpbxFiles = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCreated = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLastAccessed = new System.Windows.Forms.Button();
            this.btnAttributes = new System.Windows.Forms.Button();
            this.grpbxDirectories = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnListFiles = new System.Windows.Forms.Button();
            this.btnBrowseFolders = new System.Windows.Forms.Button();
            this.txtDirectoryFilePath = new System.Windows.Forms.TextBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.grpbxFiles.SuspendLayout();
            this.grpbxDirectories.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(658, 42);
            this.btnBrowseFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(46, 35);
            this.btnBrowseFiles.TabIndex = 0;
            this.btnBrowseFiles.Text = "...";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(39, 60);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(626, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // grpbxFiles
            // 
            this.grpbxFiles.Controls.Add(this.btnCopy);
            this.grpbxFiles.Controls.Add(this.btnCreate);
            this.grpbxFiles.Controls.Add(this.btnCreated);
            this.grpbxFiles.Controls.Add(this.btnDelete);
            this.grpbxFiles.Controls.Add(this.btnLastAccessed);
            this.grpbxFiles.Controls.Add(this.btnAttributes);
            this.grpbxFiles.Controls.Add(this.btnBrowseFiles);
            this.grpbxFiles.Location = new System.Drawing.Point(18, 18);
            this.grpbxFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxFiles.Name = "grpbxFiles";
            this.grpbxFiles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxFiles.Size = new System.Drawing.Size(729, 260);
            this.grpbxFiles.TabIndex = 2;
            this.grpbxFiles.TabStop = false;
            this.grpbxFiles.Text = "Files";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(490, 168);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(159, 58);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(267, 168);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 58);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreated
            // 
            this.btnCreated.Location = new System.Drawing.Point(21, 168);
            this.btnCreated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreated.Name = "btnCreated";
            this.btnCreated.Size = new System.Drawing.Size(159, 58);
            this.btnCreated.TabIndex = 4;
            this.btnCreated.Text = "Created";
            this.btnCreated.UseVisualStyleBackColor = true;
            this.btnCreated.Click += new System.EventHandler(this.btnCreated_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 100);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 58);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLastAccessed
            // 
            this.btnLastAccessed.Location = new System.Drawing.Point(267, 100);
            this.btnLastAccessed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLastAccessed.Name = "btnLastAccessed";
            this.btnLastAccessed.Size = new System.Drawing.Size(159, 58);
            this.btnLastAccessed.TabIndex = 2;
            this.btnLastAccessed.Text = "Last Accessed";
            this.btnLastAccessed.UseVisualStyleBackColor = true;
            this.btnLastAccessed.Click += new System.EventHandler(this.btnLastAccessed_Click);
            // 
            // btnAttributes
            // 
            this.btnAttributes.Location = new System.Drawing.Point(21, 100);
            this.btnAttributes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAttributes.Name = "btnAttributes";
            this.btnAttributes.Size = new System.Drawing.Size(159, 58);
            this.btnAttributes.TabIndex = 1;
            this.btnAttributes.Text = "Attributes";
            this.btnAttributes.UseVisualStyleBackColor = true;
            this.btnAttributes.Click += new System.EventHandler(this.btnAttributes_Click);
            // 
            // grpbxDirectories
            // 
            this.grpbxDirectories.Controls.Add(this.btnClose);
            this.grpbxDirectories.Controls.Add(this.btnListFiles);
            this.grpbxDirectories.Controls.Add(this.btnBrowseFolders);
            this.grpbxDirectories.Controls.Add(this.txtDirectoryFilePath);
            this.grpbxDirectories.Location = new System.Drawing.Point(18, 289);
            this.grpbxDirectories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxDirectories.Name = "grpbxDirectories";
            this.grpbxDirectories.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxDirectories.Size = new System.Drawing.Size(729, 143);
            this.grpbxDirectories.TabIndex = 3;
            this.grpbxDirectories.TabStop = false;
            this.grpbxDirectories.Text = "Directories";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(490, 69);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 55);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnListFiles
            // 
            this.btnListFiles.Location = new System.Drawing.Point(21, 69);
            this.btnListFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListFiles.Name = "btnListFiles";
            this.btnListFiles.Size = new System.Drawing.Size(159, 55);
            this.btnListFiles.TabIndex = 6;
            this.btnListFiles.Text = "List Files";
            this.btnListFiles.UseVisualStyleBackColor = true;
            // 
            // btnBrowseFolders
            // 
            this.btnBrowseFolders.Location = new System.Drawing.Point(658, 29);
            this.btnBrowseFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseFolders.Name = "btnBrowseFolders";
            this.btnBrowseFolders.Size = new System.Drawing.Size(46, 35);
            this.btnBrowseFolders.TabIndex = 4;
            this.btnBrowseFolders.Text = "...";
            this.btnBrowseFolders.UseVisualStyleBackColor = true;
            // 
            // txtDirectoryFilePath
            // 
            this.txtDirectoryFilePath.Location = new System.Drawing.Point(21, 29);
            this.txtDirectoryFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDirectoryFilePath.Name = "txtDirectoryFilePath";
            this.txtDirectoryFilePath.Size = new System.Drawing.Size(626, 26);
            this.txtDirectoryFilePath.TabIndex = 5;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "dlgOpenFile";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 451);
            this.Controls.Add(this.grpbxDirectories);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.grpbxFiles);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "FileManagement";
            this.grpbxFiles.ResumeLayout(false);
            this.grpbxDirectories.ResumeLayout(false);
            this.grpbxDirectories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox txtDirectoryFilePath;
		private System.Windows.Forms.Button btnBrowseFolders;
		private System.Windows.Forms.Button btnListFiles;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox grpbxDirectories;
		private System.Windows.Forms.Button btnAttributes;
		private System.Windows.Forms.Button btnLastAccessed;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreated;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.GroupBox grpbxFiles;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}
