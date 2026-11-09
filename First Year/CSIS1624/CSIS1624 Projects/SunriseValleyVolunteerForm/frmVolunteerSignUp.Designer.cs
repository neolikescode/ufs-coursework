/*2029139488
 *Neo Kgatla
 *Semester Test 1
 */
namespace Question_1
{
    partial class frmVolunteerSignUp
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpShift = new System.Windows.Forms.GroupBox();
            this.radEvening = new System.Windows.Forms.RadioButton();
            this.radAfternoon = new System.Windows.Forms.RadioButton();
            this.radMorning = new System.Windows.Forms.RadioButton();
            this.grpSkills = new System.Windows.Forms.GroupBox();
            this.chkTeamLead = new System.Windows.Forms.CheckBox();
            this.chkFirstAid = new System.Windows.Forms.CheckBox();
            this.chkTransport = new System.Windows.Forms.CheckBox();
            this.lblVolunteers = new System.Windows.Forms.Label();
            this.lstVolunteers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpShift.SuspendLayout();
            this.grpSkills.SuspendLayout();
            this.SuspendLayout();
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Volunteer Name:";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(120, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 1;
            //
            // grpShift
            //
            this.grpShift.Controls.Add(this.radEvening);
            this.grpShift.Controls.Add(this.radAfternoon);
            this.grpShift.Controls.Add(this.radMorning);
            this.grpShift.Location = new System.Drawing.Point(20, 50);
            this.grpShift.Name = "grpShift";
            this.grpShift.Size = new System.Drawing.Size(260, 95);
            this.grpShift.TabIndex = 2;
            this.grpShift.TabStop = false;
            this.grpShift.Text = "Select Shift";
            //
            // radEvening
            //
            this.radEvening.AutoSize = true;
            this.radEvening.Location = new System.Drawing.Point(15, 70);
            this.radEvening.Name = "radEvening";
            this.radEvening.Size = new System.Drawing.Size(160, 17);
            this.radEvening.TabIndex = 2;
            this.radEvening.TabStop = true;
            this.radEvening.Text = "Evening (15:00 - 19:00)";
            this.radEvening.UseVisualStyleBackColor = true;
            //
            // radAfternoon
            //
            this.radAfternoon.AutoSize = true;
            this.radAfternoon.Location = new System.Drawing.Point(15, 45);
            this.radAfternoon.Name = "radAfternoon";
            this.radAfternoon.Size = new System.Drawing.Size(168, 17);
            this.radAfternoon.TabIndex = 1;
            this.radAfternoon.TabStop = true;
            this.radAfternoon.Text = "Afternoon (11:00 - 15:00)";
            this.radAfternoon.UseVisualStyleBackColor = true;
            //
            // radMorning
            //
            this.radMorning.AutoSize = true;
            this.radMorning.Location = new System.Drawing.Point(15, 20);
            this.radMorning.Name = "radMorning";
            this.radMorning.Size = new System.Drawing.Size(155, 17);
            this.radMorning.TabIndex = 0;
            this.radMorning.TabStop = true;
            this.radMorning.Text = "Morning (07:00 - 11:00)";
            this.radMorning.UseVisualStyleBackColor = true;
            //
            // grpSkills
            //
            this.grpSkills.Controls.Add(this.chkTeamLead);
            this.grpSkills.Controls.Add(this.chkFirstAid);
            this.grpSkills.Controls.Add(this.chkTransport);
            this.grpSkills.Location = new System.Drawing.Point(20, 155);
            this.grpSkills.Name = "grpSkills";
            this.grpSkills.Size = new System.Drawing.Size(260, 95);
            this.grpSkills.TabIndex = 3;
            this.grpSkills.TabStop = false;
            this.grpSkills.Text = "Skills / Resources (optional)";
            //
            // chkTeamLead
            //
            this.chkTeamLead.AutoSize = true;
            this.chkTeamLead.Location = new System.Drawing.Point(15, 70);
            this.chkTeamLead.Name = "chkTeamLead";
            this.chkTeamLead.Size = new System.Drawing.Size(155, 17);
            this.chkTeamLead.TabIndex = 2;
            this.chkTeamLead.Text = "Team-Leader Experience";
            this.chkTeamLead.UseVisualStyleBackColor = true;
            this.chkTeamLead.CheckedChanged += new System.EventHandler(this.chkSkills_CheckedChanged);
            //
            // chkFirstAid
            //
            this.chkFirstAid.AutoSize = true;
            this.chkFirstAid.Location = new System.Drawing.Point(15, 45);
            this.chkFirstAid.Name = "chkFirstAid";
            this.chkFirstAid.Size = new System.Drawing.Size(103, 17);
            this.chkFirstAid.TabIndex = 1;
            this.chkFirstAid.Text = "First-Aid Trained";
            this.chkFirstAid.UseVisualStyleBackColor = true;
            this.chkFirstAid.CheckedChanged += new System.EventHandler(this.chkSkills_CheckedChanged);
            //
            // chkTransport
            //
            this.chkTransport.AutoSize = true;
            this.chkTransport.Location = new System.Drawing.Point(15, 20);
            this.chkTransport.Name = "chkTransport";
            this.chkTransport.Size = new System.Drawing.Size(97, 17);
            this.chkTransport.TabIndex = 0;
            this.chkTransport.Text = "Own Transport";
            this.chkTransport.UseVisualStyleBackColor = true;
            this.chkTransport.CheckedChanged += new System.EventHandler(this.chkSkills_CheckedChanged);
            //
            // lblVolunteers
            //
            this.lblVolunteers.AutoSize = true;
            this.lblVolunteers.Location = new System.Drawing.Point(300, 20);
            this.lblVolunteers.Name = "lblVolunteers";
            this.lblVolunteers.Size = new System.Drawing.Size(70, 13);
            this.lblVolunteers.TabIndex = 4;
            this.lblVolunteers.Text = "Sign-Up List:";
            //
            // lstVolunteers
            //
            this.lstVolunteers.FormattingEnabled = true;
            this.lstVolunteers.Location = new System.Drawing.Point(300, 40);
            this.lstVolunteers.Name = "lstVolunteers";
            this.lstVolunteers.Size = new System.Drawing.Size(280, 212);
            this.lstVolunteers.TabIndex = 5;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(20, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(120, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(220, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(490, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // frmVolunteerSignUp
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstVolunteers);
            this.Controls.Add(this.lblVolunteers);
            this.Controls.Add(this.grpSkills);
            this.Controls.Add(this.grpShift);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVolunteerSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunrise Volunteer Drive - Task Sign-Up Board";
            this.grpShift.ResumeLayout(false);
            this.grpShift.PerformLayout();
            this.grpSkills.ResumeLayout(false);
            this.grpSkills.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpShift;
        private System.Windows.Forms.RadioButton radEvening;
        private System.Windows.Forms.RadioButton radAfternoon;
        private System.Windows.Forms.RadioButton radMorning;
        private System.Windows.Forms.GroupBox grpSkills;
        private System.Windows.Forms.CheckBox chkTeamLead;
        private System.Windows.Forms.CheckBox chkFirstAid;
        private System.Windows.Forms.CheckBox chkTransport;
        private System.Windows.Forms.Label lblVolunteers;
        private System.Windows.Forms.ListBox lstVolunteers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}
