using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentReg
{
    public partial class FrmStdReg : Form
    {
        public FrmStdReg()
        {
            InitializeComponent();
            //Populates the Qualificaions combo box
            cmbQualification.Items.Add("Bachelor of Science in Chemistry");
            cmbQualification.Items.Add("Bachelor of Science in Information Technology");
            cmbQualification.Items.Add("Bachelor of Science in Mathematics");
            cmbQualification.Items.Add("Bachelor of Science in Agriculture");

            //Populates the gender combo box
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Prefer not to say");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            //Defends against not entering text in one of the text boxes, and not choosing an option in the combo boxes
            if (txtStdNo.Text == "")
            {
                MessageBox.Show("Please enter your student number");
                return;
            }
            else if (txtFName.Text == "")
            {
                MessageBox.Show("Please enter your first name");
                return;
            }
            else if (txtLName.Text == "")
            {
                MessageBox.Show("Please enter your Last name");
                return;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your email");
                return;
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter your Phone Number");
                return;
            }
            else if (cmbQualification.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a qualification");
                return;
            }
            else if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a gender");
                return;
            }

            //Defensive Programming prevents user from entering invalid values
            //Checks if any module is selected
            bool hasModule = false;
            if (chk1614.Checked)
            {
                hasModule = true;
            }
            if (chk1624.Checked)
            {
                hasModule = true;
            }
            if (chk2614.Checked)
            {
                hasModule = true;
            }
            if (chk2664.Checked)
            {
                hasModule = true;
            }
            if (chk3714.Checked)
            {
                hasModule = true;
            }
            if (chk3744.Checked)
            {
                hasModule = true;
            }
            //diisplays this message if no value is selected
            if(hasModule == false)
            {
                MessageBox.Show("Please select a module");
                return;
            }

            //Checks if a year of study is selected
            string year = "";
            if (rdbFirstYear.Checked)
            {
                year = rdbFirstYear.Text;

                rdbSecondYear.Checked = false;
                rdbThirdYear.Checked = false;
            }
            else if (rdbSecondYear.Checked)
            {
                year = rdbSecondYear.Text;

                rdbFirstYear.Checked = false;
                rdbThirdYear.Checked = false;
            }
            else if (rdbThirdYear.Checked)
            {
                year = rdbThirdYear.Text;

                rdbFirstYear.Checked = false;
                rdbSecondYear.Checked = false;
            }
            else 
            {
                MessageBox.Show("Please select a year of Study");
                return;
            };


            //Store the information entered
            string stdNo = txtStdNo.Text;
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            MessageBox.Show($"Student No: {txtStdNo.Text}\n" +
               $"Name: {txtFName.Text} {txtLName.Text}\n" +
               $"Email: {txtEmail.Text}\n" +
               $"Phone: {txtPhone.Text}\n" +
               $"Qualification: {cmbQualification.Text}\n" +
               $"Gender: {cmbGender.Text}\n" +
               $"Date Registered: {dtpDate.Value.ToShortDateString()}");
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStdNo.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            cmbQualification.SelectedIndex = - 1;
            cmbGender.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;

            chk1614.Checked = false;
            chk1624.Checked = false;
            chk2664.Checked = false;
            chk2614.Checked = false;
            chk3714.Checked = false;
            chk3744.Checked = false;

            rdbFirstYear.Checked = false;
            rdbSecondYear.Checked = false;
            rdbThirdYear.Checked = false;

            dtpDate.Value = DateTime.Now;
            MessageBox.Show("Cleared Successfully!");

        }
    }
}
