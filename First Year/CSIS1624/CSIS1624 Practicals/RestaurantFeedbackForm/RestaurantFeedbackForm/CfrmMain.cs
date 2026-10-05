using System;
using System.Windows.Forms;

namespace RestaurantFeedbackForm
{
    public partial class CfrmMain : Form
    {
        // Class-level variable used to build up the comma-separated
        // list of aspects the user has checked.
        private string sSelectedAspects = "";

        public CfrmMain()
        {
            InitializeComponent();

            // Populate the Dining Option drop-down list.
            cmbDiningOption.Items.Add("Dine-In");
            cmbDiningOption.Items.Add("Takeaway");
            cmbDiningOption.Items.Add("Delivery");
            cmbDiningOption.Items.Add("Private Event");
            cmbDiningOption.Items.Add("Buffet");
            cmbDiningOption.Items.Add("Business Lunch");
            cmbDiningOption.Items.Add("Catering");

            // Wire up the shared CheckedChanged event handler to all
            // three "Aspects to Rate" checkboxes.
            chkFoodQuality.CheckedChanged += AspectsToRateCheckedChanged;
            chkService.CheckedChanged += AspectsToRateCheckedChanged;
            chkAmbience.CheckedChanged += AspectsToRateCheckedChanged;
        }

        // Determines which of the four Overall Experience radio buttons
        // is currently selected and returns the value of its Text
        // property. Not an event handler - called from btnSubmit_Click.
        private string GetSelectedRadioButton()
        {
            string sExperience;

            if (radExcellent.Checked)
            {
                sExperience = radExcellent.Text;
            }
            else if (radGood.Checked)
            {
                sExperience = radGood.Text;
            }
            else if (radAverage.Checked)
            {
                sExperience = radAverage.Text;
            }
            else
            {
                sExperience = radPoor.Text;
            }

            return sExperience;
        }

        // Shared event handler for all three "Aspects to Rate" checkboxes.
        // Rebuilds the class-level sSelectedAspects variable every time
        // any one of the three checkboxes is checked or unchecked, so it
        // always reflects the current combination of ticked boxes.
        private void AspectsToRateCheckedChanged(object sender, EventArgs e)
        {
            sSelectedAspects = "";

            if (chkFoodQuality.Checked)
            {
                sSelectedAspects += chkFoodQuality.Text + ", ";
            }

            if (chkService.Checked)
            {
                sSelectedAspects += chkService.Text + ", ";
            }

            if (chkAmbience.Checked)
            {
                sSelectedAspects += chkAmbience.Text + ", ";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            dtpVisitDate.Value = DateTime.Now;
            radExcellent.Checked = true;
            chkFoodQuality.Checked = false;
            chkService.Checked = false;
            chkAmbience.Checked = false;
            cmbDiningOption.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Bonus challenge: check that both textboxes have been filled
            // in and that a Dining Option has been selected before
            // displaying the feedback summary.
            if (txtName.Text == "" || txtEmail.Text == "" || cmbDiningOption.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sAspects = sSelectedAspects.TrimEnd(',', ' ');

                string sSummary = "Feedback submitted successfully!" + Environment.NewLine + Environment.NewLine +
                    "Name:  " + txtName.Text + Environment.NewLine +
                    "Email:  " + txtEmail.Text + Environment.NewLine +
                    "Date of Visit:  " + dtpVisitDate.Value.ToString("yyyy/MM/dd") + Environment.NewLine +
                    "Overall Experience:  " + GetSelectedRadioButton() + Environment.NewLine +
                    "Dining Option:  " + cmbDiningOption.Text + Environment.NewLine +
                    "Aspects to Rate:  " + sAspects;

                MessageBox.Show(sSummary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
