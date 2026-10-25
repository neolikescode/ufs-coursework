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
    //CDog class that is a type of animal, it inheritas properties and methods from the animal class
    class CDog : CAnimal
    {
        //property to store the breed of the dog
        public string Breed { get; private set; }
        //creates a parameterized constructor for the dog class
        public CDog(string name, AnimalType type, string breed) :base(name, type)
        {
            Breed = breed;
        }
        //overrides the abstract method from the parent class to create a description specific to the dog class
        public override string Describe()
        {
            return $"{Breed} Dog: {Name} says Woof!";
        }
    }
}
