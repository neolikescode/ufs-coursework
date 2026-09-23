/*Neo Kgatla
 *2029139488
 *Practical 8
 *17/09/2026
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRegistry
{
    //CBird class that is a type of animal, it inheritas properties and methods from the animal class
    class CBird : CAnimal
    {
        //property to store the size of the bird
        public string Size { get; private set; }
        //creates a parameterized constructor for the bird class
        public CBird(string name, AnimalType type, string size):base(name, type)
        {
            Size = size;
        }
        //overrides the abstract method from the parent class to create a description specific to the bird class
        public override string Describe()
        {
            return $"{Size} Bird: {Name} says Tweet!";
        }
    }
}
