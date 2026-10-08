/*Neo Kgatla
 *2029139488
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CfrmAnimals
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

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
			CdlgAnimalDetails animal = new CdlgAnimalDetails();
			if (animal.ShowDialog() == DialogResult.OK) 
			{
				lstbxAnimals.Items.Add(animal.animal);

                lstbxAnimals.DisplayMember = "Name";
            }
			
        }
    }
}
