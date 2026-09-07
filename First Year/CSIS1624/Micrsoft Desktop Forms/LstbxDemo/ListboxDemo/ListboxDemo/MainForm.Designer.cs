/*
 * Created by SharpDevelop.
 * User: Jay
 * Date: 2026/08/26
 * Time: 14:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ListboxDemo
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
            this.grpAddItem = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.grpAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddItem
            // 
            this.grpAddItem.Controls.Add(this.btnAdd);
            this.grpAddItem.Controls.Add(this.txtItem);
            this.grpAddItem.Location = new System.Drawing.Point(18, 385);
            this.grpAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddItem.Name = "grpAddItem";
            this.grpAddItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddItem.Size = new System.Drawing.Size(579, 108);
            this.grpAddItem.TabIndex = 9;
            this.grpAddItem.TabStop = false;
            this.grpAddItem.Text = "Add Item to List";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(424, 45);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(22, 48);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(380, 26);
            this.txtItem.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(432, 95);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 46);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 40);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(18, 40);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(388, 324);
            this.lstItems.TabIndex = 6;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(18, 14);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(49, 20);
            this.lblItems.TabIndex = 5;
            this.lblItems.Text = "Items";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 522);
            this.Controls.Add(this.grpAddItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lblItems);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "ListboxDemo";
            this.grpAddItem.ResumeLayout(false);
            this.grpAddItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label lblItems;
		private System.Windows.Forms.ListBox lstItems;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtItem;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox grpAddItem;
	}
}
