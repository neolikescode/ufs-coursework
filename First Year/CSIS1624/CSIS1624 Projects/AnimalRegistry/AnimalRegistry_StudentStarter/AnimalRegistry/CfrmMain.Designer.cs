// Name: Neo Kgatla
// Student Number:2029139488
// Date: 17/09/2026

namespace AnimalRegistry
{
    partial class CfrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radDog;
        private System.Windows.Forms.RadioButton radCat;
        private System.Windows.Forms.RadioButton radBird;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox lstAnimals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radDog = new System.Windows.Forms.RadioButton();
            this.radCat = new System.Windows.Forms.RadioButton();
            this.radBird = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.txtBreedColourSize = new System.Windows.Forms.TextBox();
            this.lblBreedColourSize = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 1;
            // 
            // radDog
            // 
            this.radDog.AutoSize = true;
            this.radDog.Location = new System.Drawing.Point(15, 43);
            this.radDog.Name = "radDog";
            this.radDog.Size = new System.Drawing.Size(45, 17);
            this.radDog.TabIndex = 2;
            this.radDog.TabStop = true;
            this.radDog.Text = "Dog";
            this.radDog.UseVisualStyleBackColor = true;
            // 
            // radCat
            // 
            this.radCat.AutoSize = true;
            this.radCat.Location = new System.Drawing.Point(66, 43);
            this.radCat.Name = "radCat";
            this.radCat.Size = new System.Drawing.Size(41, 17);
            this.radCat.TabIndex = 3;
            this.radCat.TabStop = true;
            this.radCat.Text = "Cat";
            this.radCat.UseVisualStyleBackColor = true;
            // 
            // radBird
            // 
            this.radBird.AutoSize = true;
            this.radBird.Location = new System.Drawing.Point(113, 43);
            this.radBird.Name = "radBird";
            this.radBird.Size = new System.Drawing.Size(43, 17);
            this.radBird.TabIndex = 4;
            this.radBird.TabStop = true;
            this.radBird.Text = "Bird";
            this.radBird.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(282, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(363, 10);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 85);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(55, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Animals: 0";
            // 
            // lstAnimals
            // 
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.Location = new System.Drawing.Point(15, 104);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(423, 147);
            this.lstAnimals.TabIndex = 8;
            // 
            // txtBreedColourSize
            // 
            this.txtBreedColourSize.Location = new System.Drawing.Point(113, 65);
            this.txtBreedColourSize.Name = "txtBreedColourSize";
            this.txtBreedColourSize.Size = new System.Drawing.Size(163, 20);
            this.txtBreedColourSize.TabIndex = 10;
            // 
            // lblBreedColourSize
            // 
            this.lblBreedColourSize.AutoSize = true;
            this.lblBreedColourSize.Location = new System.Drawing.Point(12, 68);
            this.lblBreedColourSize.Name = "lblBreedColourSize";
            this.lblBreedColourSize.Size = new System.Drawing.Size(95, 13);
            this.lblBreedColourSize.TabIndex = 9;
            this.lblBreedColourSize.Text = "Breed/Colour/Size";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBreedColourSize);
            this.Controls.Add(this.lblBreedColourSize);
            this.Controls.Add(this.lstAnimals);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radBird);
            this.Controls.Add(this.radCat);
            this.Controls.Add(this.radDog);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "CfrmMain";
            this.Text = "Animal Registry";
            this.Load += new System.EventHandler(this.CfrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtBreedColourSize;
        private System.Windows.Forms.Label lblBreedColourSize;
        private System.Windows.Forms.Button btnSave;
    }
}
