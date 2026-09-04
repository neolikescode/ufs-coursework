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
            dlgOpenFile.Filter = "JSON Files|*.json";
            dlgOpenFile.Title = "Select a JSON File";

            string file = dlgOpenFile.FileName;
            if (!string.IsNullOrWhiteSpace(file))
            {
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(file).ToLower() == ".json")
                    {
                        txtFilePath.Text = dlgOpenFile.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid JSON file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtFilePath.Text = "Choose a file";
                }
            }
            else
            {
                txtFilePath.Text = "Choose a valid file";
            }
        }

        private void btnAttributes_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(txtFilePath.Text))
                {
                    FileInfo info = new FileInfo(txtFilePath.Text);
                    string attributes = info.Attributes.ToString();

                    MessageBox.Show($"ATTRIBUTES: {attributes}");
                }
                else
                {
                    MessageBox.Show("File does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLastAccessed_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(txtFilePath.Text))
                {
                    FileInfo info = new FileInfo(txtFilePath.Text);
                    string lastAccessed = info.LastAccessTime.ToString();
                    MessageBox.Show($"Last Accessed: {lastAccessed}");
                }
                else
                {
                    MessageBox.Show("File does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(File.Exists(txtFilePath.Text))
            {
                try
                {
                    DialogResult response = MessageBox.Show("Are you sure you want to delete, this file? ", "Delete File! ", 
                                                            MessageBoxButtons.YesNo , MessageBoxIcon.Warning,
                                                            MessageBoxDefaultButton.Button2);
                    if(response == DialogResult.Yes)
                    {
                        File.Delete(txtFilePath.Text);
                    }
                    else
                    {
                        MessageBox.Show("Operation cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(txtFilePath.Text))
                {
                    using (FileStream fs = File.Create(txtFilePath.Text))
                    { }
                    MessageBox.Show("File created successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("File already exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreated_Click(object sender, EventArgs e)
        {
           if (File.Exists(txtFilePath.Text))
            {
                try
                {
                    FileInfo info = new FileInfo(txtFilePath.Text);
                    MessageBox.Show($"File Created: {info.CreationTime}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           else
           {
                MessageBox.Show("File does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtFilePath.Text))
            {
                try
                {
                    
                    dlgSaveFile.Filter = "JSON Files|*.json";
                    dlgSaveFile.Title = "Save JSON Files";

                    if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        string destination = dlgSaveFile.FileName;

                        if (!File.Exists(destination))
                        {
                            File.Copy(txtFilePath.Text, destination);
                            MessageBox.Show($"File successfully copied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("File already exists at this location ", "File Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFolders_Click(object sender, EventArgs e)
        {
            try
            { 
                FolderBrowserDialog dlgFolder = new FolderBrowserDialog();
                

                if (dlgFolder.ShowDialog() == DialogResult.OK)
                {
                    txtDirectoryFilePath.Text = dlgFolderBrowser.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Enter correct Directory Name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


