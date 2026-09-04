using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Simple_Greeting_Form
{
    public partial class frmModuleManager : Form
    {
        List<string> modules = new List<string>();
        public frmModuleManager()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtModule.Text != "" )
            {
                modules.Add(txtModule.Text);
                lstModules.Items.Add(txtModule.Text);
                txtModule.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a module", "Enter Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstModules.SelectedIndex != -1)
            {
                int selectedIndex = lstModules.SelectedIndex;
                modules.RemoveAt(selectedIndex);
                lstModules.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a Module", "Select Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (lstModules.SelectedIndex != -1)
            {
                string selectedMod = lstModules.SelectedItem.ToString();
                int selectedIndex = lstModules.SelectedIndex;
                int countMods = lstModules.Items.Count;
                lblInfo.Text = $"Selected: {selectedMod}\nPosition: {selectedIndex + 1}\nTotal Modules: {countMods}";
            }
            else
            {
                MessageBox.Show("Please select a Module First", "Select Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
