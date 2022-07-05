using System;
using System.Collections;
using static System.Console;
using System.Threading;//For sleep execution
namespace stack_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack new_stack = new Stack();
            new_stack.Push("Hello");
            new_stack.Push("Hi");
            new_stack.Push(33);
            WriteLine("Elements after push operation in Stack");
            foreach (var element in new_stack)
                {
                Console.WriteLine(element);
            }
            Thread.Sleep(2000);
            WriteLine("To check the string present in the stack ");
            Thread.Sleep(2000);
            WriteLine("\nEnter the string;(case sensitive)");
            string message = ReadLine();
            Thread.Sleep(2000);
            if (new_stack.Contains(message) == true)
            {
                WriteLine($"********{message} is found*******");
            }
            else
            {
                WriteLine($"*********{message} cannot be found****");
            }
            Thread.Sleep(2000);
            WriteLine("\nNow after the pop() operation we have");
            Thread.Sleep(2000);
            new_stack.Pop();

            foreach (var element in new_stack)
                {
                Console.WriteLine(element);
            }
            Thread.Sleep(2000);
            WriteLine("\nElement on the top of the stack is ");
            Thread.Sleep(3000);
            WriteLine(new_stack.Peek());


        }
    }
}
