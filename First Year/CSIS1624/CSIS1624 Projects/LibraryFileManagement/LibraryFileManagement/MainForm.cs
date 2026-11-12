using System;
using System.Windows.Forms;
using System.IO;

namespace LibraryFileManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // TODO: Implement your backend logic here.
        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            string filePath = txtFileName.Text;
            if (String.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show($"Please enter appropriate file name", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (File.Exists(filePath))
                {
                    MessageBox.Show($"{filePath} exists", "FILE EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{filePath} does not exists", "DOES NOT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string filePath = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please enter a file path.",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(
                    filePath, FileMode.CreateNew, FileAccess.Write))
                {
                    // File is created and the stream is closed automatically.
                }

                MessageBox.Show($"{filePath} has been created successfully.",
                    "FILE CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshList();
            }
            catch (IOException)
            {
                MessageBox.Show("The file already exists or an I/O error occurred.",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred: {ex.Message}",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFileName.Text;

                if (string.IsNullOrWhiteSpace(filePath))
                {
                    MessageBox.Show("Please enter a file name.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (File.Exists(filePath))
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to delete this file?", "DELETE FILE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        File.Delete(filePath);

                        MessageBox.Show($"{filePath} has been deleted successfully", "FILE DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshList();
                    }
                }
                else
                {
                    MessageBox.Show($"{filePath} does not exist", "FILE DOES NOT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred: {ex.Message}","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
           string dir = txtFilePath.Text;
            if (string.IsNullOrWhiteSpace(dir))
            {
                MessageBox.Show("Please enter a directory path.","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Directory.Exists(dir))
            {
                MessageBox.Show($" This folder '{dir}' Already exists", "FOLDER EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList();
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(dir);
                    MessageBox.Show($"'{dir}' has been created successfully", "FOLDER CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex.Message}", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string filePath = txtFileName.Text;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please enter a file path.");
                return;
            }

            if (File.Exists(filePath))
            {
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    rtbFileContent.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex.Message}", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"{filePath} does not exists", "FILE EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            string filePath = txtFileName.Text;

            if (File.Exists(filePath))
            {
                try
                {
                    string content = rtbFileContent.Text;

                    using (StreamWriter sw = new StreamWriter(filePath, false))
                    {
                        sw.Write(content);
                    }

                    MessageBox.Show("Content written successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occurred: {ex.Message}","ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"{filePath} does not exist","FILE DOES NOT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAppendFile_Click(object sender, EventArgs e)
        {
            string filePath = txtFileName.Text;
            if (File.Exists(filePath))
            {
                try
                {
                    string content = rtbFileContent.Text;
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine(content);
                        MessageBox.Show("content written successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex.Message}", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"{filePath} does not exists", "FILE DOES NOT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlgOpen.Title = "Select a file";
            dlgOpen.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            dlgOpen.InitialDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlgOpen.FileName;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgSave.Filter = "Text Files (*.txt)|*.txt";

            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string save = dlgSave.FileName;
                    File.WriteAllText(save, rtbFileContent.Text);

                    MessageBox.Show($"Content successfully saved at {save}", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occurred: {ex.Message}", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void RefreshList()
        {
            lstFiles.Items.Clear();
            string filePath = txtFilePath.Text;
            if (Directory.Exists(filePath))
            {
                string[] files = Directory.GetFiles(filePath);
                foreach (var item in files)
                {
                    lstFiles.Items.Add(Path.GetFileName(item));
                }
            }
        }
        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(lstFiles.SelectedIndex != -1)
           {
                string fileName = lstFiles.SelectedItem.ToString();
                string fullPath = Path.Combine(txtFilePath.Text, fileName);
                if (File.Exists(fullPath))
                {
                    try
                    {
                        using(StreamReader sr = new StreamReader(fullPath))
                        {
                            string line = sr.ReadToEnd();
                           rtbFileContent.Text = line;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error has occured: {ex.Message}", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"{fullPath} does not exists", "FILE DOES NOT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           }
           else
           {
                rtbFileContent.Clear();
                MessageBox.Show($"Please select an item to display", "SELECT ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            
        }
    }
}