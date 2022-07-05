using System;
using System.Collections.Generic;
using static System.Console;
namespace hashSet_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> obj1 = new HashSet<string>()
            {"C#","Python","Java","HTML"}; //Both the method are valid

            /*obj1.Add("C#");
            obj1.Add("Python");
            obj1.Add("Java");
            */

            foreach (var item in obj1)
            {
                WriteLine(item);
            }


            /*WriteLine();
            WriteLine("\nPerforming remove operation"); //operations are remove(),clear(),removewhere();
            WriteLine("Total number of elements before removing= "+obj1.Count);
            obj1.Remove("Java"); //Here we perform only remove();
            WriteLine("\nAfter performing remove operation= "+obj1.Count);
            */

            
            WriteLine("\n Set Operations");//IntersectWith(), UnionWith(), ExceptWith()
            //Creating next HashSet()
            WriteLine("\n New HashSet is");
            HashSet<string> obj2 = new HashSet<string>(){"PHP","C#","Python","C"};
            foreach (var item in obj2)
            {
                WriteLine(item);
            }
            WriteLine();
            WriteLine("Intersection Operations");
            obj1.IntersectWith(obj2);
            foreach (var item in obj1)
            {
                WriteLine(item);
            }

        }
    }
}
