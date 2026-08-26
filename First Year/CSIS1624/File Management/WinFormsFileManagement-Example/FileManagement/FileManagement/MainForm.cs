/*
 * Created by SharpDevelop.
 * User: Jay
 * Date: 2026/08/25
 * Time: 14:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FileManagement
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
			if(dlgOpenFile.ShowDialog()==DialogResult.OK)
			{
				txtFilePath.Text = dlgOpenFile.FileName;
			}
        }

        private void btnAttributes_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtFilePath.Text))
            {
				string attributes = File.GetAttributes(txtFilePath.Text).ToString();

				MessageBox.Show($"Attrbutes: {attributes}", "File Attribute(s)", MessageBoxButtons.OK);
            }
        }

        private void btnLastAccessed_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtFilePath.Text))
            {
                string lastAccessed = File.GetLastAccessTime(txtFilePath.Text).ToString();

                MessageBox.Show($"Attrbutes: {lastAccessed}", "File Attribute(s)", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
