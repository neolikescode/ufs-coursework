/* Neo Kgatla
 * 2029139488
 * Practical 7
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthTracker
{
    internal class Pet
    {
		//three private fields to store each pet's name, age and weight
		private string sName;
        private int iAge;
        private double dWeight;

        //three public properties to access each private data field above
        public string Name
        {
			get { return sName; }
			set { sName = value; }
		}
		public int Age
        {
			get { return iAge; }
			set { iAge = value; }
		}
		public double Weight
        {
			get { return dWeight; }
			set { dWeight = value; }
		}
        //default constructor which will be used to initialise objects of the class in the Program class
        public Pet()
		{

		}

        //method that will write all the pet’s details to the screen
		public void DisplayPetInfo()
		{
			string info = $"Name:\t{Name}\nAge:\t{Age}\nWeight: {Weight:F1} Kg";
			Console.WriteLine(info);
        }
    }
}
