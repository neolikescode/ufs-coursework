namespace Simple_Greeting_Form
{
    partial class frmModuleManager
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
            this.txtModule = new System.Windows.Forms.TextBox();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstModules = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(180, 73);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(213, 26);
            this.txtModule.TabIndex = 0;
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(13, 78);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(115, 20);
            this.lblModuleName.TabIndex = 1;
            this.lblModuleName.Text = "Module Name: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 57);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Module";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstModules
            // 
            this.lstModules.FormattingEnabled = true;
            this.lstModules.ItemHeight = 20;
            this.lstModules.Location = new System.Drawing.Point(12, 231);
            this.lstModules.Name = "lstModules";
            this.lstModules.Size = new System.Drawing.Size(227, 144);
            this.lstModules.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(151, 381);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 57);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Module";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(111, 160);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 5;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(270, 381);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(94, 57);
            this.btnShowInfo.TabIndex = 6;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // frmModuleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstModules);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.txtModule);
            this.Name = "frmModuleManager";
            this.Text = "Module Manager GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstModules;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnShowInfo;
    }
}

