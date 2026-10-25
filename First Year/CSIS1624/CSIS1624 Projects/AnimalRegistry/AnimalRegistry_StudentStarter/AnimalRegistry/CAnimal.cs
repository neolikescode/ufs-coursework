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
    abstract class CAnimal
    {
        //2 Properties that will store the animal name and type
        public string Name { get; private set; }
        public AnimalType Type { get; set; }

        //2 properties that get the list of animals and number of animals
        public static List<CAnimal> ListOfAnimals = new List<CAnimal>();

        public static int NumberOfAnimals { get; set; }

        //Parameterized Constructor, that gets the animal name, and type 
        public CAnimal(string name, AnimalType type)
        {
            Name = name;
            Type = type;
            NumberOfAnimals++;
        }
        //
        public abstract string Describe();
    }
}
