using System;
namespace SOLID
{
    public class Animal{
        public void Eat(){
            Console.WriteLine("I can eat");
        }
        public void Walk(){
            Console.WriteLine("I can Walk");
        }
        public void Sleep(){
            Console.WriteLine("Sleeping");
        }
    }

    public class Cat : Animal
    {
    }

    public class Dog : Animal
    {
        
    }
}