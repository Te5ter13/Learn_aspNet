using System;
using System.Collections.Generic;
using static System.Console;

namespace student_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dict_obj = new Dictionary<int, string>();
            dict_obj.Add(2,"Ram");
            dict_obj.Add(3,"Hari");
            dict_obj.Add(1,"Rawan");
            foreach (KeyValuePair<int,string> item in dict_obj)
            {
                WriteLine($"Key:{item.Key}  Value:{item.Value}");
            }
            WriteLine();
            //Now finding the info of student with id 1 and display it
            WriteLine("Display the student with id 1\n");
            if(dict_obj.ContainsKey(1) == true){
                WriteLine($"Name of student with id 1 is '{dict_obj[1]}'");
            }
        }
    }
}
