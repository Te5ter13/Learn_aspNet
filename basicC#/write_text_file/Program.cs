using System;
using System.IO;
using static System.Console;
using System.Threading;
namespace write_text_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "/home/tester13/Documents/Dotnet_Lab/newfile"; //This is for my linux environment
            WriteLine("Enter a sentence or a paragraph");
            string message = ReadLine();
            File.WriteAllText(file,message);
            WriteLine();
            WriteLine("Checking to read the file that exists or not");
            if (File.Exists(file))
            {
                Thread.Sleep(2000);
                WriteLine("File Exists");
                Thread.Sleep(2000);
                WriteLine();
                WriteLine("The text of the file is");
                Thread.Sleep(2000);
                WriteLine(File.ReadAllText(file));
            }
            else
            {
                WriteLine("There is no such file");
            }

        }
    }
}
