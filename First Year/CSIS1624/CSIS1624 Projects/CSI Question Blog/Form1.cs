using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI_Question_Blog
{
    public partial class frmCSIQuestionBlog : Form
    {
        public frmCSIQuestionBlog()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks to see if user entered text
                if (!string.IsNullOrWhiteSpace(txtQuestion.Text))
                {
                    //Ensures the filestream is closed successfully
                    using (FileStream fs = new FileStream("Questions.txt", FileMode.Append, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Writes the question the user submits to the questions file
                        sw.WriteLine(txtQuestion.Text);
                    }
                    //Removes the text the user has submitted
                    txtQuestion.Clear();
                    //Informs user their question has been submitted
                    MessageBox.Show("Question successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your textbox is empty!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occured: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                //Ensures the filestream is closed successfully
                using (StreamReader sr = new StreamReader("Questions.txt"))
                {
                    //Reads the data from the Questions file and displays it on the TextBox
                    txtQuestion.Clear();
                    txtQuestion.Text = sr.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error has occured: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
