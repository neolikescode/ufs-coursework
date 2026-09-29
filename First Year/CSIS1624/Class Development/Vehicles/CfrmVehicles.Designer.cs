
namespace Vehicles
{
    partial class CfrmVehicles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSUV = new System.Windows.Forms.RadioButton();
            this.radMotorcycle = new System.Windows.Forms.RadioButton();
            this.radCar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDisp = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSUV);
            this.groupBox1.Controls.Add(this.radMotorcycle);
            this.groupBox1.Controls.Add(this.radCar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Type";
            // 
            // radSUV
            // 
            this.radSUV.AutoSize = true;
            this.radSUV.Location = new System.Drawing.Point(157, 19);
            this.radSUV.Name = "radSUV";
            this.radSUV.Size = new System.Drawing.Size(47, 17);
            this.radSUV.TabIndex = 2;
            this.radSUV.TabStop = true;
            this.radSUV.Text = "SUV";
            this.radSUV.UseVisualStyleBackColor = true;
            this.radSUV.CheckedChanged += new System.EventHandler(this.radSUV_CheckedChanged);
            // 
            // radMotorcycle
            // 
            this.radMotorcycle.AutoSize = true;
            this.radMotorcycle.Location = new System.Drawing.Point(66, 19);
            this.radMotorcycle.Name = "radMotorcycle";
            this.radMotorcycle.Size = new System.Drawing.Size(77, 17);
            this.radMotorcycle.TabIndex = 1;
            this.radMotorcycle.TabStop = true;
            this.radMotorcycle.Text = "Motorcycle";
            this.radMotorcycle.UseVisualStyleBackColor = true;
            this.radMotorcycle.CheckedChanged += new System.EventHandler(this.radMotorcycle_CheckedChanged);
            // 
            // radCar
            // 
            this.radCar.AutoSize = true;
            this.radCar.Location = new System.Drawing.Point(6, 19);
            this.radCar.Name = "radCar";
            this.radCar.Size = new System.Drawing.Size(41, 17);
            this.radCar.TabIndex = 0;
            this.radCar.TabStop = true;
            this.radCar.Text = "Car";
            this.radCar.UseVisualStyleBackColor = true;
            this.radCar.CheckedChanged += new System.EventHandler(this.radCar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year of Production";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(12, 82);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(66, 20);
            this.txtMake.TabIndex = 4;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(84, 82);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(69, 20);
            this.txtmodel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Of Doors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type Of Bike";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Displacement";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(12, 130);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(66, 20);
            this.txtNo.TabIndex = 10;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(84, 130);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(66, 20);
            this.txtType.TabIndex = 11;
            // 
            // txtDisp
            // 
            this.txtDisp.Location = new System.Drawing.Point(168, 130);
            this.txtDisp.Name = "txtDisp";
            this.txtDisp.Size = new System.Drawing.Size(66, 20);
            this.txtDisp.TabIndex = 12;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(93, 156);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "Display Info";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vehicle Count:";
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.Location = new System.Drawing.Point(13, 197);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(237, 95);
            this.lstVehicle.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // CfrmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 312);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lstVehicle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtDisp);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CfrmVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CfrmVehicles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSUV;
        private System.Windows.Forms.RadioButton radMotorcycle;
        private System.Windows.Forms.RadioButton radCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDisp;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

