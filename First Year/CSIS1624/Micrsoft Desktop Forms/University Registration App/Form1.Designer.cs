namespace Solution
{
    partial class CfrmRegistrationApp
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
            this.grpbxUserDetails = new System.Windows.Forms.GroupBox();
            this.radFinalYear = new System.Windows.Forms.RadioButton();
            this.radSecondYear = new System.Windows.Forms.RadioButton();
            this.radThirdYear = new System.Windows.Forms.RadioButton();
            this.radFirstYear = new System.Windows.Forms.RadioButton();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpbxUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxUserDetails
            // 
            this.grpbxUserDetails.Controls.Add(this.radFinalYear);
            this.grpbxUserDetails.Controls.Add(this.radSecondYear);
            this.grpbxUserDetails.Controls.Add(this.radThirdYear);
            this.grpbxUserDetails.Controls.Add(this.radFirstYear);
            this.grpbxUserDetails.Controls.Add(this.cmbDepartment);
            this.grpbxUserDetails.Controls.Add(this.lblDepartment);
            this.grpbxUserDetails.Controls.Add(this.txtName);
            this.grpbxUserDetails.Controls.Add(this.lblName);
            this.grpbxUserDetails.Location = new System.Drawing.Point(20, 18);
            this.grpbxUserDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxUserDetails.Name = "grpbxUserDetails";
            this.grpbxUserDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxUserDetails.Size = new System.Drawing.Size(300, 240);
            this.grpbxUserDetails.TabIndex = 4;
            this.grpbxUserDetails.TabStop = false;
            this.grpbxUserDetails.Text = "User Details";
            // 
            // radFinalYear
            // 
            this.radFinalYear.AutoSize = true;
            this.radFinalYear.Location = new System.Drawing.Point(150, 189);
            this.radFinalYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radFinalYear.Name = "radFinalYear";
            this.radFinalYear.Size = new System.Drawing.Size(106, 24);
            this.radFinalYear.TabIndex = 7;
            this.radFinalYear.TabStop = true;
            this.radFinalYear.Text = "Final Year";
            this.radFinalYear.UseVisualStyleBackColor = true;
            // 
            // radSecondYear
            // 
            this.radSecondYear.AutoSize = true;
            this.radSecondYear.Location = new System.Drawing.Point(150, 154);
            this.radSecondYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSecondYear.Name = "radSecondYear";
            this.radSecondYear.Size = new System.Drawing.Size(127, 24);
            this.radSecondYear.TabIndex = 6;
            this.radSecondYear.TabStop = true;
            this.radSecondYear.Text = "Second Year";
            this.radSecondYear.UseVisualStyleBackColor = true;
            // 
            // radThirdYear
            // 
            this.radThirdYear.AutoSize = true;
            this.radThirdYear.Location = new System.Drawing.Point(14, 189);
            this.radThirdYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radThirdYear.Name = "radThirdYear";
            this.radThirdYear.Size = new System.Drawing.Size(107, 24);
            this.radThirdYear.TabIndex = 5;
            this.radThirdYear.TabStop = true;
            this.radThirdYear.Text = "Third Year";
            this.radThirdYear.UseVisualStyleBackColor = true;
            // 
            // radFirstYear
            // 
            this.radFirstYear.AutoSize = true;
            this.radFirstYear.Location = new System.Drawing.Point(14, 154);
            this.radFirstYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radFirstYear.Name = "radFirstYear";
            this.radFirstYear.Size = new System.Drawing.Size(103, 24);
            this.radFirstYear.TabIndex = 4;
            this.radFirstYear.TabStop = true;
            this.radFirstYear.Text = "First Year";
            this.radFirstYear.UseVisualStyleBackColor = true;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            //this.cmbDepartment.Items.AddRange(new object[] {
            //"Health Sciences",
            //"Humanities",
            //"Law",
            //"Natural and Agricultural Sciences"});
            this.cmbDepartment.Location = new System.Drawing.Point(105, 86);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(180, 28);
            this.cmbDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(9, 91);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(94, 20);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 43);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Solution.Properties.Resources.UFS_Logo;
            this.picLogo.Location = new System.Drawing.Point(351, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(297, 305);
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(207, 288);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 288);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CfrmRegistrationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 354);
            this.Controls.Add(this.grpbxUserDetails);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CfrmRegistrationApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Application";
            this.grpbxUserDetails.ResumeLayout(false);
            this.grpbxUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxUserDetails;
        private System.Windows.Forms.RadioButton radFinalYear;
        private System.Windows.Forms.RadioButton radSecondYear;
        private System.Windows.Forms.RadioButton radThirdYear;
        private System.Windows.Forms.RadioButton radFirstYear;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}

