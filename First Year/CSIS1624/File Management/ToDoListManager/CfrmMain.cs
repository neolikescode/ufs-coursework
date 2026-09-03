// Name: Neo Kgatla
// Student Number: 2029139488
// Practical: 6
// Date: 03 September 2026

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ToDoListManager
{
    public partial class CfrmMain : Form
    {
        //TODO: declare a class-level List<string> variable named oToDoItems to hold the current in-memory to-do list#
        List<string> oToDoItems = new List<string>();
        public CfrmMain()
        {
            InitializeComponent();

            //TODO: wire up the Click event handlers for btnBrowse, btnLoad, btnSave, btnAddItem, btnRemoveItem and btnDeleteFile#
            this.btnBrowse.Click += btnBrowse_Click;
            this.btnLoad.Click += btnLoad_Click;
            this.btnSave.Click += btnSave_Click;
            this.btnAddItem.Click += btnAddItem_Click;
            this.btnRemoveItem.Click += btnRemoveItem_Click;
            this.btnDeleteFile.Click += btnDeleteFile_Click;
        }

        //TODO: create a helper method named RefreshFileInfoLabels() that uses the FileInfo class to update
        //lblCreatedValue and lblLastModifiedValue with the current file's creation time and last write time.
        //If the file does not exist, both labels should be reset to "-"#
        private void RefreshFileInfoLabels()
        {
            if (File.Exists(txtFilePath.Text))
            {
                FileInfo selectedFile = new FileInfo(txtFilePath.Text);

                lblCreatedValue.Text = selectedFile.CreationTime.ToString();
                lblLastModifiedValue.Text = selectedFile.LastWriteTime.ToString();
            }
            else
            {
                lblCreatedValue.Text = "-";
                lblLastModifiedValue.Text = "-";
            }
        }

        //TODO: create a helper method named ResetToDoList() that clears oToDoItems, clears lstItems,
        //and resets the Created/Last Modified labels back to "-"#
        private void ResetToDoList()
        {
            oToDoItems.Clear();
            lstItems.Items.Clear();
            lblCreatedValue.Text = "-";
            lblLastModifiedValue.Text = "-";
        }
        //TODO: create the btnBrowse_Click event handler.
        //Use dlgOpen.ShowDialog() to let the user select a .json file.
        //If the DialogResult is OK, assign the selected file path to txtFilePath.Text
        //and call RefreshFileInfoLabels()#
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlgOpen.FileName;

                RefreshFileInfoLabels();
            }
        }

        //TODO: create the btnLoad_Click event handler.
        //Check that the file in txtFilePath.Text exists before continuing.
        //Inside a try-catch block: read the file's text with File.ReadAllText(), deserialize it into
        //oToDoItems using JsonSerializer.Deserialize<List<string>>(), clear and repopulate lstItems
        //from oToDoItems, then call RefreshFileInfoLabels().
        //If the file does not exist, display an appropriate warning MessageBox#
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtFilePath.Text))
            {
                try
                {
                    string jsonString = File.ReadAllText(txtFilePath.Text);

                    oToDoItems = JsonSerializer.Deserialize<List<string>>(jsonString);

                    lstItems.Items.Clear();
                    
                    for(int i = 0; i < oToDoItems.Count; i++)
                    {
                        lstItems.Items.Add(oToDoItems[i]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                                       ex.Message,
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }

        //TODO: create the btnAddItem_Click event handler.
        //Append the text in txtNewItem to oToDoItems and to lstItems, then clear txtNewItem#
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            oToDoItems.Add(txtNewItem.Text);
            lstItems.Items.Add(txtNewItem.Text);
            txtNewItem.Clear();
        }

        //TODO: create the btnRemoveItem_Click event handler.
        //If an item is selected in lstItems, remove it from both oToDoItems and lstItems#
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if(lstItems.SelectedIndex != -1)
            {
                int index = lstItems.SelectedIndex;

                lstItems.Items.RemoveAt(index);
                oToDoItems.RemoveAt(index);
            }
        }

        //TODO: create the btnSave_Click event handler.
        //Check that txtFilePath.Text is not empty before continuing.
        //Inside a try-catch block: serialize oToDoItems to a JSON string using JsonSerializer.Serialize()
        //(use a JsonSerializerOptions object with WriteIndented set to true), write it to the file with
        //File.WriteAllText(), call RefreshFileInfoLabels(), and show a success MessageBox.
        //If the file path is empty, display an appropriate warning MessageBox#
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                try
                {
                    JsonSerializerOptions opt = new JsonSerializerOptions { WriteIndented = true };

                    string jsonString = JsonSerializer.Serialize(oToDoItems, opt);

                    File.WriteAllText(txtFilePath.Text, jsonString);

                    RefreshFileInfoLabels();
                    MessageBox.Show($"Text successfully saved to {Path.GetFileName(txtFilePath.Text)}");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            else
            {
                MessageBox.Show("Invalid File Name ");
            }
        }
        //TODO: create the btnDeleteFile_Click event handler.
        //Check that the file in txtFilePath.Text exists before continuing.
        //Ask the user to confirm the deletion with a Yes/No MessageBox (defensive programming).
        //Only delete the file with File.Delete() if the user clicks Yes, then clear txtFilePath and
        //call ResetToDoList(). If the file does not exist, display an appropriate warning MessageBox#
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if(File.Exists(txtFilePath.Text))
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this file? This action cannot be undone.", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (response == DialogResult.Yes)
                {
                    File.Delete(txtFilePath.Text);
                    txtFilePath.Clear();
                    ResetToDoList();
                }
            }
            else
            {
                MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
