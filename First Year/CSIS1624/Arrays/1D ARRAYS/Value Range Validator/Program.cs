using System;

namespace Arrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of values you want to enter: ");
            int numberOfValues = int.Parse(Console.ReadLine());

            int[] counts = new int[11];

            int invalidRange = 0;
            int invalidNonNumeric = 0;
            int validTotal = 0;

            Console.WriteLine();

            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                string entry = Console.ReadLine();

                int value;

                if (int.TryParse(entry, out value))
                {
                    if (value >= 0 && value <= 10)
                    {
                        counts[value]++;
                        validTotal++;
                    }
                    else
                    {
                        invalidRange++;
                    }
                }
                else
                {
                    invalidNonNumeric++;
                }
            }

            Console.WriteLine("\n========== RESULTS ==========");

            Console.WriteLine($"Valid values entered: {validTotal}");
            Console.WriteLine($"Invalid range values: {invalidRange}");
            Console.WriteLine($"Invalid non-numeric values: {invalidNonNumeric}");

            Console.WriteLine("\n========== VALID VALUES ==========");

            Console.WriteLine($"{"Value",-10}{"Count",10}");

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i,-10}{counts[i],10}");
                }
            }

            Console.ReadKey();
        }
    }
}