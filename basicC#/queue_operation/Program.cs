using System;
using System.Collections;
using static System.Console;
using System.Threading;

namespace queue_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue obj = new Queue();
            obj.Enqueue("Hello");
            obj.Enqueue("There");
            obj.Enqueue("C#");
            WriteLine("Objects in Queue are\n");

            Thread.Sleep(2000);
            foreach (var item in obj)
            {
                WriteLine(item);
            }
            WriteLine();
            Thread.Sleep(2000);
            WriteLine("Total Number of elements in queue is -->"+obj.Count);
            Thread.Sleep(2000);
            WriteLine();
            WriteLine("To check the elements present in queue");
            Thread.Sleep(2000);
            WriteLine("Enter the string");
            string message = ReadLine();
            Thread.Sleep(2000);
            if (obj.Contains(message) == true){
                WriteLine($"\n{message} element found \n");
            }
            else{
                WriteLine($"{message} element not found\n");
            }
            Thread.Sleep(2000);
            WriteLine("Performing Dequeue operation");
            obj.Dequeue();
            WriteLine("After dequeue() operation, Elements are ");
            WriteLine();
            Thread.Sleep(2000);
            foreach (var item in obj)
            {
                WriteLine(item);
            }
        }

    }
}
