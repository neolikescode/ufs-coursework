using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Questions_Form
{
    public partial class frmCSIQuestionBlog : Form
    {
        string filePath = @"Questions.txt";
        public frmCSIQuestionBlog()
        {
            InitializeComponent();
            btnSave.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string question = txtQuestion.Text;
                if (!string.IsNullOrWhiteSpace(question))
                {
                    using (StreamWriter w = new StreamWriter(filePath, true))
                    {
                        w.WriteLine(question);
                    }
                    txtQuestion.Clear();
                }
                else
                {
                    MessageBox.Show("Your textbox is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText(filePath);

            if (!string.IsNullOrWhiteSpace(text))
            {
                txtQuestion.Text = text;
            }
            else
            {
                MessageBox.Show("No Questions asked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to close this form? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(answer == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
