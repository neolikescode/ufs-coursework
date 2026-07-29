/* ============== READ ME ==============
 * All the code provided may NOT be edited or changed
 * Only add the relevant code to the sections demarkated for each question
 * Marks will be deducted if there is no comment block below this
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("       LOOP DEMO MENU        ");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Counter-Controlled Loop (for)");
                Console.WriteLine("2. State-Controlled Loop (while)");
                Console.WriteLine("3. Sentinel-Controlled Loop (do-while)");
                Console.WriteLine("0. Exit");
                Console.WriteLine("=============================");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                int count = 0;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n--- Counter-Controlled Loop (for) ---");
                        Console.Write("How many times should the loop run? ");
                        count = int.Parse(Console.ReadLine());
                        while (count <= 0)
                        {
                            Console.Write("Please enter a valid positive number: ");
                            count = int.Parse(Console.ReadLine());
                        }

                        // ============== Question 1: For Loop Code must be added below ==============
                        for (int i = 1; i <= count; i++)
                        {
                            Console.WriteLine($" Iteration {i} of {count}");
                        }
                        // ============== Question 1: End ==============

                        Console.WriteLine("Loop complete.");
                        break;

                    case "2":
                        int points = 0;
                        int visits = 0;
                        bool notEnoughPoints = true;

                        // ============== Question 2: While Loop Code must be added below ==============
                        while (notEnoughPoints)
                        {
                            points += 15;
                            visits++;
                            
                            Console.WriteLine($"Visit {visits}: {points} points");
                            if (points >= 100)
                            {
                                notEnoughPoints = false;
                            }
                        }


                        // ============== Question 2: End ==============

                        Console.WriteLine($"\nYou earned your free coffee after {visits} visits!");
                        break;

                    case "3":
                        double mark;
                        double total = 0;
                        Console.WriteLine("Enter test marks (enter -1 to finish):");

                        // ============== Question 3: do - While Loop Code must be added below ==============
                        do
                        {
                            Console.Write("Mark: ");
                            mark = double.Parse(Console.ReadLine());

                            if (mark != -1)
                            {
                                total += mark;
                                count++;
                            }
                        }
                        while (mark != -1);
                        // ============== Question 3: End ==============
                        if (count > 0)
                        {
                            double average = total / count;
                            Console.WriteLine($"\nYou entered {count} marks.");
                            Console.WriteLine($"Class average: {average:F2}");
                        }
                        else
                        {
                            Console.WriteLine("\nNo marks were entered.");
                        }
                        break;

                    case "0":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
