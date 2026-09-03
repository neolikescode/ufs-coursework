// Name: 
// Student Number: 
// Practical: 6
// Date: 

namespace ToDoListManager
{
    partial class CfrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.grpbxFile = new System.Windows.Forms.GroupBox();
            this.lblLastModifiedValue = new System.Windows.Forms.Label();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.lblCreatedValue = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.grpbxItems = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.lblNewItem = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.grpbxFile.SuspendLayout();
            this.grpbxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            this.dlgOpen.Title = "Select a To-Do List JSON File";
            // 
            // grpbxFile
            // 
            this.grpbxFile.Controls.Add(this.lblLastModifiedValue);
            this.grpbxFile.Controls.Add(this.lblLastModified);
            this.grpbxFile.Controls.Add(this.lblCreatedValue);
            this.grpbxFile.Controls.Add(this.lblCreated);
            this.grpbxFile.Controls.Add(this.btnDeleteFile);
            this.grpbxFile.Controls.Add(this.btnSave);
            this.grpbxFile.Controls.Add(this.btnLoad);
            this.grpbxFile.Controls.Add(this.btnBrowse);
            this.grpbxFile.Controls.Add(this.txtFilePath);
            this.grpbxFile.Controls.Add(this.lblFilePath);
            this.grpbxFile.Location = new System.Drawing.Point(18, 18);
            this.grpbxFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxFile.Name = "grpbxFile";
            this.grpbxFile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxFile.Size = new System.Drawing.Size(615, 246);
            this.grpbxFile.TabIndex = 0;
            this.grpbxFile.TabStop = false;
            this.grpbxFile.Text = "File";
            // 
            // lblLastModifiedValue
            // 
            this.lblLastModifiedValue.AutoSize = true;
            this.lblLastModifiedValue.Location = new System.Drawing.Point(165, 203);
            this.lblLastModifiedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastModifiedValue.Name = "lblLastModifiedValue";
            this.lblLastModifiedValue.Size = new System.Drawing.Size(14, 20);
            this.lblLastModifiedValue.TabIndex = 9;
            this.lblLastModifiedValue.Text = "-";
            // 
            // lblLastModified
            // 
            this.lblLastModified.AutoSize = true;
            this.lblLastModified.Location = new System.Drawing.Point(22, 203);
            this.lblLastModified.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(108, 20);
            this.lblLastModified.TabIndex = 8;
            this.lblLastModified.Text = "Last Modified:";
            // 
            // lblCreatedValue
            // 
            this.lblCreatedValue.AutoSize = true;
            this.lblCreatedValue.Location = new System.Drawing.Point(165, 168);
            this.lblCreatedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedValue.Name = "lblCreatedValue";
            this.lblCreatedValue.Size = new System.Drawing.Size(14, 20);
            this.lblCreatedValue.TabIndex = 7;
            this.lblCreatedValue.Text = "-";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(22, 168);
            this.lblCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(70, 20);
            this.lblCreated.TabIndex = 6;
            this.lblCreated.Text = "Created:";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(454, 105);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(138, 43);
            this.btnDeleteFile.TabIndex = 5;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 105);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(140, 105);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(138, 43);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(488, 46);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 35);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(135, 49);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(342, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(22, 54);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(75, 20);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "File Path:";
            // 
            // grpbxItems
            // 
            this.grpbxItems.Controls.Add(this.btnRemoveItem);
            this.grpbxItems.Controls.Add(this.btnAddItem);
            this.grpbxItems.Controls.Add(this.txtNewItem);
            this.grpbxItems.Controls.Add(this.lblNewItem);
            this.grpbxItems.Controls.Add(this.lstItems);
            this.grpbxItems.Location = new System.Drawing.Point(18, 280);
            this.grpbxItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxItems.Name = "grpbxItems";
            this.grpbxItems.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxItems.Size = new System.Drawing.Size(615, 400);
            this.grpbxItems.TabIndex = 1;
            this.grpbxItems.TabStop = false;
            this.grpbxItems.Text = "To-Do Items";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(454, 94);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(138, 43);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(488, 46);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(105, 35);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(135, 49);
            this.txtNewItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(342, 26);
            this.txtNewItem.TabIndex = 2;
            // 
            // lblNewItem
            // 
            this.lblNewItem.AutoSize = true;
            this.lblNewItem.Location = new System.Drawing.Point(22, 54);
            this.lblNewItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewItem.Name = "lblNewItem";
            this.lblNewItem.Size = new System.Drawing.Size(80, 20);
            this.lblNewItem.TabIndex = 1;
            this.lblNewItem.Text = "New Item:";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(22, 146);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(568, 224);
            this.lstItems.TabIndex = 0;
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 702);
            this.Controls.Add(this.grpbxItems);
            this.Controls.Add(this.grpbxFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List Manager";
            this.grpbxFile.ResumeLayout(false);
            this.grpbxFile.PerformLayout();
            this.grpbxItems.ResumeLayout(false);
            this.grpbxItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.GroupBox grpbxFile;
        private System.Windows.Forms.Label lblLastModifiedValue;
        private System.Windows.Forms.Label lblLastModified;
        private System.Windows.Forms.Label lblCreatedValue;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.GroupBox grpbxItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.Label lblNewItem;
        private System.Windows.Forms.ListBox lstItems;
    }
}
