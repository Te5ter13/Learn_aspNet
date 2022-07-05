using System;
using static System.Console;
using System.IO;
namespace create_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPathA = "/home/tester13/Documents/Dotnet_Lab/FolderA";
            string folderPathB = "/home/tester13/Documents/Dotnet_Lab/FolderB";
            string folderPathC = "/home/tester13/Documents/Dotnet_Lab/FolderC";    
            //Creating a directory
            Directory.CreateDirectory(folderPathA);
            Directory.CreateDirectory(folderPathB);
            Directory.CreateDirectory(folderPathC);

            string filename = "newfile";
            string sourcePath = "/home/tester13/Documents/Dotnet_Lab/";
            string destfile = Path.Combine(folderPathA,filename);
            string sourcefile = Path.Combine(sourcePath,filename);
            File.Copy(sourcefile,destfile,true);
            // To rename the file 
            File.Move($"{folderPathA}/newfile",$"{folderPathA}/ChangedFile");
        }
    }
}
