/*Neo Kgatla
 *2029139488
 *Practical 8
 *17/09/2026
 */
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace AnimalRegistry
{
    public partial class CfrmMain : Form
    {
        // === Provided ===
        public CfrmMain()
        {
            InitializeComponent();
        }
        // === Provided ===
        private static bool IsDesignMode() =>
            LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        // === Provided ===
        private void CfrmMain_Load(object sender, EventArgs e)
        {
            if (IsDesignMode()) return;
            lstAnimals.DisplayMember = "Name";
            lblCount.Text = "Animals: 0";
        }

        // === Button event to be completed ===
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Create the selected animal and add it to the registry.
            CAnimal animal;

            ///////////////////////////////////////////////////
            /*I had a problem with the enum parameter for the radio button, i prompted the ai
             * "how do i fix the error 'cannot convert from System.Windows.Forms.RadioButton' to 'Animal Type'"
             * ANSWER: animal = new CDog(txtName.Text, AnimalType.Dog, txtBreedColourSize.Text);*/
            //////////////////////////////////////////////////
            
            //finds the selected animal type
            if (radDog.Checked)
            {
                 animal = new CDog(txtName.Text, AnimalType.Dog, txtBreedColourSize.Text);
            }
            else if (radCat.Checked)
            {
                animal = new CCat(txtName.Text, AnimalType.Cat, txtBreedColourSize.Text);
            }
            else if (radBird.Checked)
            {
                animal = new CBird(txtName.Text, AnimalType.Bird, txtBreedColourSize.Text);
            }
            else
            {
                MessageBox.Show("Please select the type of Animal", "Select The Animal type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //adds the animal object to the list in the abstract class, and adds the name property of the object to the listbox
            CAnimal.ListOfAnimals.Add(animal);
            lstAnimals.Items.Add(animal.Name);
            //displays the number of animals added
            lblCount.Text = CAnimal.NumberOfAnimals.ToString();
        }

        // === Button event to be completed ===
        private void btnShow_Click(object sender, EventArgs e)
        {
            // TODO: Display the selected animal's description.

            //checks to see if the user has selected an item in the list
            if(lstAnimals.SelectedIndex != -1)
            {
                string selectedAnimal = lstAnimals.SelectedItem.ToString();
                ///////////////////////////////////////////////////
                /*i had a problem because theAnimal might not have a value before being used, i prompted the ai
                 *"how do I fix the error of this variable possibly not having a value?"
                 * ANSWER:Problem 1: theAnimal may not have a value A safer approach is: CAnimal theAnimal = null;*/
                //////////////////////////////////////////////////
                CAnimal theAnimal = null;

                //loops through all animal objects stored in ListOfAnimals.
                foreach (CAnimal animal in CAnimal.ListOfAnimals)
                {
                    //searches the animal list for an object with the same name as the selected ListBox item.
                    if (selectedAnimal == animal.Name)
                    {
                        //stores the animal object so its information can be displayed later.
                        theAnimal = animal;
                        break;
                    }
                }
                //Shows the user the information of the selected animal
                MessageBox.Show($"{theAnimal.Describe()}");
            }
        }

        // === Button event to be completed ===
        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Save all animal descriptions to List of Animals.txt.
            string fileName = @"List of Animals.txt";

            //writes to the file inside the debug folder
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                //loops through the list of animals and writes the info to the file
                foreach(CAnimal animal in CAnimal.ListOfAnimals)
                {
                    sw.WriteLine(animal.Describe());

                }
                //displays a success message
                MessageBox.Show("File Successfully Saved.");

            }
        }
    }
}
