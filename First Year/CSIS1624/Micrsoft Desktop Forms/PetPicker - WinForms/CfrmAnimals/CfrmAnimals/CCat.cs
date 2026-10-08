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
    public class CCat : CAnimals
    {
        public string Colour { get; set; }

        public CCat(string name, int age, string colour) : base(name, age)
        {
            Colour = colour;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{base.Name} the {Colour} Cat makes a Meow sound");
        }
    }
}
