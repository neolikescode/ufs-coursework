using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamesReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("========== File Management ===========\n");

                string fileN = "students.txt";

                List<string> students = new List<string>()
                {
                    "Neo",
                    "Nel",
                    "Ner"
                };

                using (FileStream fw = new FileStream(fileN, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter w = new StreamWriter(fw))
                    {
                        for (int i = 0; i < students.Count; i++)
                        {
                            w.WriteLine(students[i]);
                        }
                    }
                }

                using (FileStream fr = new FileStream(fileN, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader r = new StreamReader(fr))
                    {
                        string line;
                        while (!r.EndOfStream)
                        {
                            line = r.ReadLine();

                            students.Add(line);
                        }

                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine($"{students[i]}\n");
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
