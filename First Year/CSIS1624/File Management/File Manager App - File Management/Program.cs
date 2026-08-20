using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Menu_Driven_file_mnger____File_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("=== File Manager Menu ===");
                Console.WriteLine("1. Create a new text file\n2. Write to a text file\n3. Read a text file\n4.Copy a file");
                Console.WriteLine("5.Delete a file.\n6.Move/Rename a file\n7. Get file information\n8. Exit");
                Console.Write("Enter your choice(1 - 8): ");
                int iChoice = int.Parse(Console.ReadLine());
                
                switch(iChoice)
                {
                    case 1:
                        CreateFile();
                        break;
                    case 2:
                        WriteToFile();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        keepRunning = false;
                        break;
                }

            }
            
        }
        private static void CreateFile()
        {
            Console.Write("Enter the file path to create (e.g .., test.txt): ");
            try
            {
                string filePath = Console.ReadLine();
                if(File.Exists(filePath))
                {
                    Console.WriteLine("File already exists. ");
                }
                else
                {
                   using FileStream Fs = File.Create(filePath);
                    Console.WriteLine($"File created successfully at {filePath}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An errror has occurred, please try again: {ex.Message}");
            }
        }
        private static void WriteToFile()
        {
            try
            {
                Console.Write("Enter the file path and a line of text: ");
                string fileWritten = Console.ReadLine();

                if(File.Exists(fileWritten))
                {
                    using (StreamWriter w = new StreamWriter(fileWritten, true))
                    {
                        w.Write(fileWritten);
                    }
                }
                else
                {
                    Console.WriteLine("File Does Not Exist!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occurred, please try again: {ex.Message}");
            }
        }
        private static void ReadFile()
        {
            Console.Write("Enter the file path to read from: ");
            try
            {
                string fileRead = Console.ReadLine();
                if(File.Exists(fileRead))
                {
                    using(StreamReader r = new StreamReader (fileRead, true))
                    {
                        
                    }
                }
                else
                {
                    Console.WriteLine($"Error, file does not exist, please try again: ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred, please try again: {ex.Message}");
            }
        }
    }
}
