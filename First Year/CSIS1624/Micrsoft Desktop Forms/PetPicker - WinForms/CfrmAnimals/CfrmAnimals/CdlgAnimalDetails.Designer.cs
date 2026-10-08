/*
 * Created by SharpDevelop.
 * User: Jay
 * Date: 2024/10/09
 * Time: 11:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CfrmAnimals
{
	partial class CdlgAnimalDetails
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblBreedColour = new System.Windows.Forms.Label();
            this.txtBreedColour = new System.Windows.Forms.TextBox();
            this.grpbxAnimal = new System.Windows.Forms.GroupBox();
            this.radCat = new System.Windows.Forms.RadioButton();
            this.radDog = new System.Windows.Forms.RadioButton();
            this.grpbxAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(54, 422);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 35);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(18, 123);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(150, 35);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(15, 168);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(148, 26);
            this.txtAge.TabIndex = 3;
            // 
            // lblBreedColour
            // 
            this.lblBreedColour.Location = new System.Drawing.Point(20, 334);
            this.lblBreedColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreedColour.Name = "lblBreedColour";
            this.lblBreedColour.Size = new System.Drawing.Size(150, 35);
            this.lblBreedColour.TabIndex = 6;
            this.lblBreedColour.Text = "Breed/Colour";
            // 
            // txtBreedColour
            // 
            this.txtBreedColour.Location = new System.Drawing.Point(16, 378);
            this.txtBreedColour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBreedColour.Name = "txtBreedColour";
            this.txtBreedColour.Size = new System.Drawing.Size(148, 26);
            this.txtBreedColour.TabIndex = 5;
            // 
            // grpbxAnimal
            // 
            this.grpbxAnimal.Controls.Add(this.radCat);
            this.grpbxAnimal.Controls.Add(this.radDog);
            this.grpbxAnimal.Location = new System.Drawing.Point(18, 208);
            this.grpbxAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxAnimal.Name = "grpbxAnimal";
            this.grpbxAnimal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxAnimal.Size = new System.Drawing.Size(183, 122);
            this.grpbxAnimal.TabIndex = 7;
            this.grpbxAnimal.TabStop = false;
            this.grpbxAnimal.Text = "Animal";
            // 
            // radCat
            // 
            this.radCat.Location = new System.Drawing.Point(10, 78);
            this.radCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radCat.Name = "radCat";
            this.radCat.Size = new System.Drawing.Size(156, 37);
            this.radCat.TabIndex = 1;
            this.radCat.TabStop = true;
            this.radCat.Text = "Cat";
            this.radCat.UseVisualStyleBackColor = true;
            // 
            // radDog
            // 
            this.radDog.Location = new System.Drawing.Point(10, 31);
            this.radDog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDog.Name = "radDog";
            this.radDog.Size = new System.Drawing.Size(156, 37);
            this.radDog.TabIndex = 0;
            this.radDog.TabStop = true;
            this.radDog.Text = "Dog";
            this.radDog.UseVisualStyleBackColor = true;
            // 
            // CdlgAnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 475);
            this.Controls.Add(this.grpbxAnimal);
            this.Controls.Add(this.lblBreedColour);
            this.Controls.Add(this.txtBreedColour);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CdlgAnimalDetails";
            this.Text = "CdlgAnimalDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CdlgAnimalDetails_FormClosing);
            this.grpbxAnimal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.RadioButton radDog;
		private System.Windows.Forms.RadioButton radCat;
		private System.Windows.Forms.GroupBox grpbxAnimal;
		private System.Windows.Forms.TextBox txtBreedColour;
		private System.Windows.Forms.Label lblBreedColour;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnOk;
	}
}
