/*Neo Kgatla
 *2029139488
 *Practical 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Solution
{
    public partial class CfrmRegistrationApp : Form
    {
        public CfrmRegistrationApp()
        {
            InitializeComponent();
            //adds the department options to the combo box
            cmbDepartment.Items.Add("Health Sciences");
            cmbDepartment.Items.Add("Humanities");
            cmbDepartment.Items.Add("Law");
            cmbDepartment.Items.Add("Natural and Agricultural Sciences");

        }
        public string GetSelectedRadioButton()
        {
            //Finds which radio button the user has selected and returns the text of that radiobutton
            if (radFirstYear.Checked)
            {
                return radFirstYear.Text;
            }
            else if (radSecondYear.Checked)
            {
                return radSecondYear.Text;
            }
            else if (radThirdYear.Checked)
            {
                return radThirdYear.Text;
            }
            else if (radFinalYear.Checked)
            {
                return radFinalYear.Text;
            }
            else
            {
                return "Select a Year";
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //When its clicked the button will:
            //Clear the name TextBox
            txtName.Clear();

            //Reset the department ComboBox
            cmbDepartment.SelectedIndex = -1;

            //Uncheck all RadioButtons
            radFinalYear.Checked = false;
            radFirstYear.Checked = false;
            radSecondYear.Checked = false;
            radThirdYear.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Displays a MessageBox with Name, Department, and Year
            MessageBox.Show($"Name: {txtName.Text}\nDepartment: {cmbDepartment.Text}\nYear: {GetSelectedRadioButton()}", "Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
