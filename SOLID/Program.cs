using System;
using SOLID;
namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal c = new Dog();
            c.Eat();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
