/*Neo Kgatla
 *2029139488
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CfrmAnimals
{
	/// <summary>
	/// Description of CdlgAnimalDetails.
	/// </summary>
	public partial class CdlgAnimalDetails : Form
	{
		public CAnimals animal { get; set; }
		public CdlgAnimalDetails()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		private void CdlgAnimalDetails_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				if (radDog.Checked)
				{
					animal = new CDog(txtName.Text, int.Parse(txtAge.Text), txtBreedColour.Text);
				}
				else if (radCat.Checked)
				{
					animal = new CCat(txtName.Text, int.Parse(txtAge.Text), txtBreedColour.Text);
				}
				else
				{
					MessageBox.Show("Please select an animal", "Select Animal", MessageBoxButtons.OK);
				}	
			}
		} 
	}
}
