using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class CfrmVehicles : Form
    {
        public CfrmVehicles()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sMake = txtMake.Text;
            string sModel = txtmodel.Text;
            double sDiplacement = double.Parse(txtDisp.Text);
            int iNum = int.Parse(txtNo.Text);
            DateTime year = DateTime.Parse(txtNo.Text);
            int iCount = 0;
            string sbike = txtType.Text;
            VehicleTypes type;
            if (radCar.Checked == true)
            {
                
                type = VehicleTypes.Car;
               CCar Car = new CCar(iNum,sMake, sModel, year,type,iCount);
                lstVehicle.Items.Add(Car);
            }
            else if(radMotorcycle.Checked)
            {
                type = VehicleTypes.Motorcycle;
                CMotorCycle MotorCycle = new CMotorCycle(sbike, sMake, sModel, year, type,iCount);
                lstVehicle.Items.Add(MotorCycle);
            }
            else if(radSUV.Checked)
            {
                type = VehicleTypes.SUV;
                CSUV SUV = new CSUV(sDiplacement, sMake, sModel, year, type, iCount);
                lstVehicle.Items.Add(SUV);
            }
        }

        private void radCar_CheckedChanged(object sender, EventArgs e)
        {
            txtNo.Enabled = true;
            txtDisp.Enabled = false;
            txtType.Enabled = false;

        }

        private void radMotorcycle_CheckedChanged(object sender, EventArgs e)
        {
            txtNo.Enabled = false;
            txtDisp.Enabled = false;
            txtType.Enabled = true;

        }

        private void radSUV_CheckedChanged(object sender, EventArgs e)
        {
            txtNo.Enabled = false;
            txtType.Enabled = false;
            txtDisp.Enabled = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (lstVehicle.SelectedItem is CVehicle SelectedVehicle)
            {
                string VehicleInfo = SelectedVehicle.DisplayInfo();
                MessageBox.Show(VehicleInfo);
            }
            else
            {
                MessageBox.Show("Please select a vehicle from the list.");
            }
        }
    }
}
