/* Neo Kgatla
 * 2029139488
 * Practical 4
 * 13/08/2026
 */
using System;
using System.Windows.Forms;

namespace RestaurantFeedbackForm
{
    public partial class CfrmMain : Form
    {
        // TODO: Declare a class-level variable named sSelectedAspects here.
        string sSelectedAspects;

        public CfrmMain()
            // Form Constructor
        {
            InitializeComponent();

            // TODO: In the constructor, add items to the "Dining Option"
            // drop-down list.
            cmbDiningOption.Items.Add("Dine-In");
            cmbDiningOption.Items.Add("Takeaway");
            cmbDiningOption.Items.Add("Delivery");
            cmbDiningOption.Items.Add("Private Event");
            cmbDiningOption.Items.Add("Buffet");
            cmbDiningOption.Items.Add("Business Lunch");
            cmbDiningOption.Items.Add("Catering");
        }

        // TODO: Create a method (not eventhandler) named
        // GetSelectedRadioButton() that determines which Overall
        // Experience radio button the user has selected and returns
        // the value of its Text property.
        private string GetSelectedRadioButton()
        {
            //Checks to see which option was selected
            if (radExcellent.Checked)
            {
                return radExcellent.Text;
            }
            else if (radGood.Checked)
            {
                return radGood.Text;
            }
            else if (radAverage.Checked)
            {
                return radAverage.Text;
            }
            else if (radPoor.Checked)
            {
                return radPoor.Text;
            }

            return "";
        }

        // TODO: Wire up the shared CheckedChanged event handler to
        // all three "Aspects to Rate" checkboxes.
        private void AspectsToRateCheckedChanged(object sender, EventArgs e)
        {
            //Checks to see whether a check box was clicked and stores it in a class level variable
            sSelectedAspects = "";
            if (chkFoodQuality.Checked)
            {
                sSelectedAspects += chkFoodQuality.Text + ",";
            }

            if (chkService.Checked)
            {
                sSelectedAspects += chkService.Text + ",";
            }

            if (chkAmbience.Checked)
            {
                sSelectedAspects += chkAmbience.Text + ",";
            }
        }
        // TODO: Create an event handler for the Clear button's Click
        // event that clears/resets the form controls.
        private void btnClear_Click(object sender, EventArgs e)
        {
            //removes the text in the textboxes
            txtName.Clear();
            txtEmail.Clear();

            //resets the date
            dtpVisitDate.Value = DateTime.Now;

            //resets all the radio buttons
            radExcellent.Checked = false;
            radGood.Checked = false;
            radAverage.Checked = false;
            radPoor.Checked = false;

            //resets all the check boxes
            chkFoodQuality.Checked = false;
            chkService.Checked = false;
            chkAmbience.Checked = false;

            //Resets combo box
            cmbDiningOption.SelectedIndex = -1;

            //resets th class level string
            sSelectedAspects = "";
        }

        // TODO: Create an event handler for the Submit button's Click
        // event that displays a summary of the feedback in a
        // MessageBox. (Bonus challenge: validate that the required
        // fields have been completed before showing the summary.)
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Defensive programming, ensures that user enters all fields in the form
            if (txtName.Text == "")
            {
                MessageBox.Show($"Please fill in all required fields.", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show($"Please fill in all required fields.", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmbDiningOption.SelectedIndex == -1)
            {
                MessageBox.Show($"Please fill in all required fields.", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Displays feedback to user, IF ALL REQUIRED FIELDS ARE FILLED
            MessageBox.Show($"Feedback submitted sucessfully!\nName: {txtName.Text}\n" +
                $"Email: {txtEmail.Text}\n" +
                $"Date of Visit: {dtpVisitDate.Value.ToShortDateString()}\n" +
                $"Overall Experience: {GetSelectedRadioButton()}\n" +
                $"Dining Option: {cmbDiningOption.SelectedItem}\n" +
                $"Aspects to Rate: {sSelectedAspects.TrimEnd(',', ' ')}", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

    }
}
