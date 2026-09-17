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
    //CCat class that is a type of animal, it inheritas properties and methods from the animal class
    class CCat : CAnimal
    {
        //property to store the colour of the cat
        public string Colour { get; private set; }
        //creates a parameterized constructor for the cat class
        public CCat(string name, AnimalType type , string colour):base(name, type)
        {
            Colour = colour;
        }
        //overrides the abstract method from the parent class to create a description specific to the cat class
        public override string Describe()
        {
            return $"{Colour} Cat: {Name} says Meow!";
        }
    }
}
