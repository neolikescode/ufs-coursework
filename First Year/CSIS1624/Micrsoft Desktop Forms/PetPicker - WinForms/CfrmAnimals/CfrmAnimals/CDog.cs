/*Neo Kgatla
 *2029139488
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfrmAnimals
{
    public class CDog : CAnimals
    {
        public string Breed { get; set; }

        public CDog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{base.Name} the {Breed} Dog makes a Bark sound");
        }
    }
}
