using System;

namespace method_Overriding
{
    class Animal
    {
        public virtual void Eat(){
            Console.WriteLine("Animal Eats Foods");
        }
    }
    class Dog:Animal{
        public override void Eat(){
        Console.WriteLine("Dog Eats Foods");
        }
        public static void Main(string[] args){
            Animal myanimal = new Animal();
            myanimal.Eat();
            Animal mydog = new Dog();
            mydog.Eat();
        }
    }
}


