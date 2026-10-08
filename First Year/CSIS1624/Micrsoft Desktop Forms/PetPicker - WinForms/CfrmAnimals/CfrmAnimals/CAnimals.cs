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
    public abstract class CAnimals
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public CAnimals(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void MakeSound()
        {
            string sound = $"{Name} is {Age} and makes a sound";
        }
    }
}
