/*2029139488
 *Neo Kgatla
 *Semester Test 1
 */
using System;
using System.IO;
using System.Windows.Forms;

namespace Question_1
{
    public partial class frmVolunteerSignUp : Form
    {
        // TODO: Declare a class-level string variable here to hold the
        // currently selected skills/resources (built up by chkSkills_CheckedChanged).
        public string selectedSkills;

        public frmVolunteerSignUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shared event handler for all three "skills" checkboxes
        /// (chkTransport, chkFirstAid, chkTeamLead) - already wired up
        /// to all three checkboxes in the Designer file.
        /// TODO: Rebuild the class-level skills string from scratch every
        /// time this event fires, based on which checkboxes are ticked.
        /// Remember to use TrimEnd(',', ' ') to remove any trailing
        /// separator before storing the result.
        /// </summary>
        private void chkSkills_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: implement
            selectedSkills = "";
            if (chkTransport.Checked)
            {
                selectedSkills += $"{chkTransport.Text}, ";
            }
            if(chkFirstAid.Checked)
            {
                selectedSkills += $"{chkFirstAid.Text}, ";
            }
            if (chkTeamLead.Checked)
            {
                selectedSkills += $"{chkTeamLead.Text}, ";
            }
            selectedSkills = selectedSkills.TrimEnd(',', ' ');
        }

        /// <summary>
        /// TODO: Implement this standalone helper method (it is NOT an event
        /// handler) so that it returns the text of whichever shift RadioButton
        /// (radMorning, radAfternoon, radEvening) is currently selected, or an
        /// empty string if none is selected. Use a single exit point.
        /// </summary>
        private string GetSelectedShift()
        {
            string shift = "";

            // TODO: implement
            if (radMorning.Checked)
            {
                shift = radMorning.Text;
            }
            else if (radAfternoon.Checked)
            {
                shift = radAfternoon.Text;
            }
            else if (radEvening.Checked)
            {
                shift = radEvening.Text;
            }
            return shift;
        }

        /// <summary>
        /// TODO: When the user clicks Add:
        ///  - Use GetSelectedShift() to find the selected shift.
        ///  - Show a warning MessageBox if the name textbox is empty.
        ///  - Show a warning MessageBox if no shift has been selected.
        ///  - Otherwise, build a formatted entry (name, shift, and skills if
        ///    any are selected) and add it to lstVolunteers.
        ///  - Reset all the input controls afterwards so the form is ready
        ///    for the next volunteer.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: implement
            try
            {
                string shift = GetSelectedShift();
                //Checks if the user entered a name
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name cannot be blank", "Enter Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Prevents user from not selecting a shift, by check if the user has selected a radio button
                else if (shift == "")
                {
                    MessageBox.Show("Please select a shift", "Select Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Builds the text that will be displayed on the listbox
                    string display = $"{txtName.Text}. | {shift} | {selectedSkills}";

                    //Ads the users details to the listbox and displays it on the form
                    lstVolunteers.Items.Add(display.TrimEnd('|'));

                    //Resets the form
                    //Resets the name textbox
                    txtName.Clear();
                    //Resets the shift radio buttons
                    radMorning.Checked = false;
                    radAfternoon.Checked = false;
                    radEvening.Checked = false;
                    //Resets skills checkboxes
                    chkTransport.Checked = false;
                    chkFirstAid.Checked = false;
                    chkTeamLead.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occured: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// TODO: When the user clicks Save:
        ///  - Show a warning MessageBox if lstVolunteers is empty.
        ///  - Otherwise, use a FileStream (FileMode.Create) together with a
        ///    StreamWriter to write every item in lstVolunteers to
        ///    "Volunteers.txt" (one item per line), overwriting any previous
        ///    content so the file always reflects the current list.
        ///  - Wrap the file-writing code in a try/catch block and show an
        ///    appropriate MessageBox on success and on failure.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: implement
            //Checks if the lisistbox is empty and displays the appropriate message if it is
            if (lstVolunteers.Items.Count == 0)
            {
                MessageBox.Show("List is empty", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Writes the listbox data into a file using the streamwriter class
                    using (FileStream fs = new FileStream("Volunteers.txt", FileMode.Create, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (object item in lstVolunteers.Items)
                        {
                            sw.WriteLine(item.ToString());
                        }
                        MessageBox.Show($"List successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// TODO: When the user clicks Clear:
        ///  - If lstVolunteers is already empty, let the user know.
        ///  - Otherwise, ask the user to confirm (Yes/No) before clearing
        ///    all items out of lstVolunteers.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // TODO: implement
            //Checks if the lisistbox is empty and displays the appropriate message if it is
            if (lstVolunteers.Items.Count == 0)
            {
                MessageBox.Show("List is already empty", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Checks the users choice on the dialog and decides if the list gets cleared or not
                    DialogResult clear = MessageBox.Show("Are you sure you want to clear the list?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (clear == DialogResult.Yes)
                    {
                        lstVolunteers.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// TODO: Close the form when the user clicks Close.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // TODO: implement
            //When user clicks the close button the form closes
            this.Close();
        }
    }
}
