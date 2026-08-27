// Name: Neo Kgatla
// Student Number: 2029139488
// Practical: 6
// Date: 27/08/2026

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        }

        //helper method named RefreshFileInfoLabels() that uses the FileInfo class to update
        //lblCreatedValue and lblLastModifiedValue with the current file's creation time and last write time.
        //If the file does not exist, both labels should be reset to "-"#
        private void RefreshFileInfoLabels()
        {
            //instantiates fileinfo class to access information about the file 
            FileInfo file = new FileInfo(txtFilePath.Text);
            
            //Checks if the file exists
            if (file.Exists)
            {
            
                lblCreatedValue.Text = file.CreationTime.ToString();
                lblLastModifiedValue.Text = file.LastWriteTime.ToString();
            }
            //if the file doesn't exist the values below are reset
            else
            {
                lblLastModifiedValue.Text = "-";
                lblCreatedValue.Text = "-";
            }
            
        }
        //helper method named ResetToDoList() that clears oToDoItems, clears lstItems,
        //and resets the Created/Last Modified labels back to "-"#
        private void ResetToDoList()
        {
            //clears the list and list box
            oToDoItems.Clear();
            lstItems.Items.Clear();

            //resets the values below on the form
            lblLastModifiedValue.Text = "-";
            lblCreatedValue.Text = "-";
        }

        //create the btnBrowse_Click event handler.
        //Use dlgOpen.ShowDialog() to let the user select a .json file.
        //If the DialogResult is OK, assign the selected file path to txtFilePath.Text
        //and call RefreshFileInfoLabels()#
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //checks if user has selected OK on the dialog box
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                //sets the text value to the selected file path of the user then calls RefreshFileInfoLabels method
                txtFilePath.Text = dlgOpen.FileName;
                RefreshFileInfoLabels();
            }
        }

        //create the btnLoad_Click event handler.
        //Check that the file in txtFilePath.Text exists before continuing.
        //Inside a try-catch block: read the file's text with File.ReadAllText(), deserialize it into
        //oToDoItems using JsonSerializer.Deserialize<List<string>>(), clear and repopulate lstItems
        //from oToDoItems, then call RefreshFileInfoLabels().
        //If the file does not exist, display an appropriate warning MessageBox#
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //defensive programming
            try
            {
                string file = txtFilePath.Text;
                //Checks if the file exists
                if (File.Exists(file))
                {
                    //reads all the text in the selected file and Deserializes the file
                    string jsonSting = File.ReadAllText(file);
                    oToDoItems = JsonSerializer.Deserialize<List<string>>(jsonSting);

                    //Answer: You clear the ListBox inside the loop
                    lstItems.Items.Clear();
                    //displays the to-do list
                    foreach (string text in oToDoItems)
                    {
                        Console.WriteLine(text);
                        lstItems.Items.Add(text);
                    }
                    RefreshFileInfoLabels();
                }
                //displays message if the file doesn't exist
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }
            //Handles any error that might occur and displays a message to the user
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //create the btnAddItem_Click event handler.
        //Append the text in txtNewItem to oToDoItems and to lstItems, then clear txtNewItem#
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //converts filepath text to lowercase
            string search = txtNewItem.Text.ToLower();
            //loops through the list to check if the current item already exists in the list
            for(int i = 0; i < oToDoItems.Count; i++)
            {
                string listItems = oToDoItems[i].ToLower();
                //displays a message to user if the item entered already exists and returns
                if (search == listItems)
                {
                    MessageBox.Show("Item already exists");
                    return;
                }

            }
            //if the current item entered does not exist in the list, it is then added to the list and list box
            string addItem = txtNewItem.Text;
               oToDoItems.Add(addItem);
               lstItems.Items.Add(addItem);
               txtNewItem.Clear();
        }

        //create the btnRemoveItem_Click event handler.
        //If an item is selected in lstItems, remove it from both oToDoItems and lstItems#
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //checks if an item in the list box is selected
            if (lstItems.SelectedIndex != -1)
            {
                //Bonus challenge attempt

                //asks user to confirm if they want to remove the selected item
                DialogResult response = MessageBox.Show("Are you sure you want to remove this item?", "Confirm Delete",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //if user selects yes, then item is removed from the list and list box and a message is sent to the user
                if (response == DialogResult.Yes)
                {
                    //Answer: Wrong ListBox removal method You wrote: lstItems.SelectedItems.Remove(removeItem);
                    //You want: lstItems.Items.Remove(removeItem);
                    string removeItem = lstItems.SelectedItem.ToString();

                    oToDoItems.Remove(removeItem);
                    lstItems.Items.Remove(removeItem);
                    MessageBox.Show("Item Successfully removed");
                }
                //displays a message if the user doesn't select an item
                else
                {
                    MessageBox.Show("Please select the item you want to remove.");
                }
            }
        }
        //create the btnSave_Click event handler.
        //Check that txtFilePath.Text is not empty before continuing.
        //Inside a try-catch block: serialize oToDoItems to a JSON string using JsonSerializer.Serialize()
        //(use a JsonSerializerOptions object with WriteIndented set to true), write it to the file with
        //File.WriteAllText(), call RefreshFileInfoLabels(), and show a success MessageBox.
        //If the file path is empty, display an appropriate warning MessageBox#
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //checks to see if user has selected a file path
                if(txtFilePath.Text != "")
                {
                    //Serializes the selected file into a JSON file, then displays a message to the user
                    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonSting = JsonSerializer.Serialize(oToDoItems, options);
                    File.WriteAllText(txtFilePath.Text, jsonSting);
                    RefreshFileInfoLabels();
                    MessageBox.Show("File has successfully saved!");
                }
                //prompts user to a file path
                else
                {
                    MessageBox.Show("Please enter the file path");
                }
            }
            //Handles any error that might occur and displays a message to the user
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex}");
            }
        }
        //create the btnDeleteFile_Click event handler.
        //Check that the file in txtFilePath.Text exists before continuing.
        //Ask the user to confirm the deletion with a Yes/No MessageBox (defensive programming).
        //Only delete the file with File.Delete() if the user clicks Yes, then clear txtFilePath and
        //call ResetToDoList(). If the file does not exist, display an appropriate warning MessageBox#
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            //Defensive programming
            try
            {
                //checks to see if the file exists
                if (File.Exists(txtFilePath.Text))
                {
                    //prompts user to confirm if they want to delete the selected file
                    DialogResult response = MessageBox.Show("Are you sure you want to delete the file?", "Confirm Delete", 
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //if user selects yes, the file is deleted, and a message is displayed to inform them
                    if(response == DialogResult.Yes)
                    {
                        File.Delete(txtFilePath.Text);
                        MessageBox.Show("File Successfully deleted");
                        txtFilePath.Clear();
                        ResetToDoList();
                    }
                }
                //diplays a message to the user if the file does not exist
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }
            //Handles any error that might occur and displays a message to the user
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
    }
}
