using System;
using System.Collections.Generic;
using static System.Console;
namespace dictionary_in_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> obj_dict = new Dictionary<int, string>();
            obj_dict.Add(1,"Programming");
            obj_dict.Add(2,"With");
            obj_dict.Add(3,"C#");
            WriteLine("Creating a Dictionary\n");
            foreach (KeyValuePair<int,string> item in obj_dict)
            {
                WriteLine($"Key:{item.Key}  Value:{item.Value}");
            }
            WriteLine();
            WriteLine("Checking the Availability of the elements\n");
            WriteLine("Enter the key in number ");
            int number = Convert.ToInt32(ReadLine());
            if(obj_dict.ContainsKey(number) == true){
                WriteLine($"{number} Key is available with value '{obj_dict[number]}'");
            }
            else{
                WriteLine($"{number} Key is not found");
            }
            WriteLine("Removing the elements from the Dictionary");
            obj_dict.Remove(1); //Remove method just remove the specified Key Value
            foreach (KeyValuePair<int,string> item in obj_dict)
            {
                WriteLine($"Key:{item.Key}  Value:{item.Value}");
            }
            WriteLine();
            WriteLine("Total number of key/value present :"+obj_dict.Count);
            WriteLine();
            WriteLine("Removing the all the elements from dictionary\n");
            obj_dict.Clear();
            WriteLine("Total Number of key/value present :"+obj_dict.Count);
             
        }
    }
}
