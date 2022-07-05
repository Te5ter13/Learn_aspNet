using System;

namespace named_and_positional
{
    class Program
    {
        public void Bark(int runtimes, string sound, double volume){
            Console.Write(runtimes);
            Console.Write(sound);
            Console.Write(volume);


        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Bark(2," woof ", 3.0);
            Console.WriteLine("");
            obj.Bark(3, volume:4.0 , sound:" bark");
        }
    }
}
