/*Neo Kgatla
 *2029139488
 *2025 Semester Test 2 
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

namespace SemesterTest2
{
    public partial class CfrmMainForm : Form
    {
        public CfrmMainForm()
        {
            // Provided
            InitializeComponent();
            grpBook.Enabled = true;
            grpDvd.Enabled = false;
            grpEBook.Enabled = false;

            //Solution starts here
            lstItems.DisplayMember = "Title";
        }
        // Provided
        private void radBook_CheckedChanged(object sender, EventArgs e)
        {
            grpBook.Enabled = true;
            grpDvd.Enabled = false;
            grpEBook.Enabled = false;
        }
        // Provided
        private void radDvd_CheckedChanged(object sender, EventArgs e)
        {
            grpBook.Enabled = false;
            grpDvd.Enabled = true;
            grpEBook.Enabled = false;
        }
        // Provided
        private void radEBook_CheckedChanged(object sender, EventArgs e)
        {
            grpBook.Enabled = false;
            grpDvd.Enabled = false;
            grpEBook.Enabled = true;
        }
        // Provided
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            if (cmbYear.Items.Count > 0)
            {
                cmbYear.SelectedIndex = cmbYear.Items.Count - 1;
            }
            nudPages.Value = Math.Max(1, (int)nudPages.Minimum);
            txtRegion.Clear();
            txtFormat.Clear();

            radBook.Checked = true;  
            lstItems.ClearSelected(); 
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //instantiates an object of class CItem
            CItem item;
            //creates correct item based on selected radio button and adds the information entered by te user to the properties in the classes, then adds the item to the listbox
            if (radBook.Checked)
            {
                item = new CBook(ItemType.Book, txtTitle.Text, txtAuthor.Text, int.Parse(cmbYear.Text), (int)nudPages.Value);
                lstItems.Items.Add(item);

            }
            else if (radDvd.Checked)
            {
                item = new CDvd(ItemType.Dvd, txtTitle.Text, txtAuthor.Text, int.Parse(cmbYear.Text), txtRegion.Text);
                lstItems.Items.Add(item);
            }
            else if (radEBook.Checked)
            {
                 item = new CEbook(ItemType.EBook, txtTitle.Text, txtAuthor.Text, int.Parse(cmbYear.Text), txtFormat.Text);
                 lstItems.Items.Add(item);
            }
            else
            {
                //tells the user to select a radio button
                MessageBox.Show("Please select a Media type", "No Media Chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //updates the number of total items added to the listbox
            lblCount.Text = $"Total: {CItem.Count}";
        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            //Checks if the user has selected an item
            if (lstItems.SelectedItem is CItem item)
            {
                //if user selected an item, then the information about that item is then displayed
                MessageBox.Show(item.Describe(), "Item Details",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //if the user has not selected an item then the user is prompted to select an item
                MessageBox.Show("Please select an item first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
