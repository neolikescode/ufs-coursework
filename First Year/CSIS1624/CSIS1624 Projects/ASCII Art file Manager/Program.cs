using System;
using System.Text.RegularExpressions;
using System.IO;

namespace ASCII_Art
{
    class Program
    {
        private static string StaticDirectory = @"T:/2029139488/CSIS1624/CSIS1624 Practicals/Prac5_Solution/Practical5_Question/bin/Debug"; // Change this to your desired static directory
        private static string[] files;
        static void Main()
        {
            int choice = 0;
            do
            {
                try
                {
                    Console.Clear();
                    // Get the directory to work in when the program starts
                    Console.Write($"Default directory is {StaticDirectory}\nEnter the directory path you would like to use or press enter to stick with default: ");
                    string sDir = Console.ReadLine();
                    if (sDir != "") StaticDirectory = Regex.Unescape(sDir);

                    Console.Clear();
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1. Read a text file");
                    Console.WriteLine("2. Create a text file");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                ReadFile();
                                break;
                            case 2:
                                CreateFile();
                                break;
                            case 3:
                                choice = -1;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.Press any key to try again...");
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number. \nPress any key to try again...");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.Write("Press any key to try again...");
                    Console.ReadKey();
                }
            } while (choice != -1);

        }

        private static void ReadFile()
        {
            try
            {
                //2. ReadFile

                // 1. Call GetTextFiles, return if fails
                bool exists = GetTextFiles(StaticDirectory);
                if (exists)
                {
                    // 2. Prompt user for file number
                    Console.Write("Enter the number of the file to read: ");
                    string input = Console.ReadLine();
                    if(int.TryParse(input, out int result) && result > 0 && result <= files.Length)
                    {
                        string filePath = files[result - 1];
                        string finalPath = Path.Combine(StaticDirectory, filePath);
                        Console.Clear();
                        using(StreamReader read = new StreamReader(finalPath))
                        {
                            string line2 = read.ReadToEnd();
                            Console.WriteLine(line2);
                        }
                        Console.WriteLine("\nPress any key to exit...");
                    }
                    else
                    {
                        Console.WriteLine("Please choose a valid number");
                        Console.WriteLine("Press any key to exit...");
                    }

                }
                else
                {
                    Main();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                Console.Write("Press any key to try again...");
            }
            Console.ReadKey();
        }

        private static void CreateFile()
        {
            try
            {
                //3. CreateFile
                // Check if directory exists, create if not
                if (!Directory.Exists(StaticDirectory))
                {

                }
                Console.Clear();
                Console.Write("Enter the file name (including file extension): ");
                string fileName = Console.ReadLine();

                Console.Write("Enter the text to save in the file: ");
                string newText = Console.ReadLine();

                string finalPath = Path.Combine(StaticDirectory, fileName);
                using (StreamWriter wr = new StreamWriter(finalPath, true))
                {
                    wr.WriteLine(newText);
                }
                Console.WriteLine($"File '{fileName}' created successfully.Press any key to continue");
                Console.WriteLine("Press any key to return to the menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the file: {ex.Message}");
                Console.Write("Press any key to try again...");
            }
            Console.ReadKey();
        }//Leave comment for improvement here:

        private static bool GetTextFiles(string directoryPath)
        {
            try
            {
                Console.Clear();
                if (Directory.Exists(directoryPath))
                {
                    int iCounter = 1;
                    files = Directory.GetFiles(directoryPath, "*.txt");
                    Console.WriteLine("Text files in the directory:");
                    foreach (string file in files)
                    {
                        Console.WriteLine($"{iCounter}. {Path.GetFileName(file)}");
                        iCounter++;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                    Console.Write("Press any key to try again...");
                    Console.ReadKey();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while listing files: {ex.Message}");
                Console.Write("Press any key to try again...");
                Console.ReadKey();
                return false;
            }
        }
    }
}