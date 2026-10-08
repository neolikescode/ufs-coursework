/*
 * Created by SharpDevelop.
 * User: Jay
 * Date: 2024/10/09
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CfrmAnimals
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
            this.lstbxAnimals = new System.Windows.Forms.ListBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxAnimals
            // 
            this.lstbxAnimals.FormattingEnabled = true;
            this.lstbxAnimals.ItemHeight = 20;
            this.lstbxAnimals.Location = new System.Drawing.Point(18, 18);
            this.lstbxAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbxAnimals.Name = "lstbxAnimals";
            this.lstbxAnimals.Size = new System.Drawing.Size(204, 284);
            this.lstbxAnimals.TabIndex = 0;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(63, 326);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(112, 35);
            this.btnAddAnimal.TabIndex = 1;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 378);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.lstbxAnimals);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "CfrmAnimals";
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnAddAnimal;
		private System.Windows.Forms.ListBox lstbxAnimals;
	}
}
