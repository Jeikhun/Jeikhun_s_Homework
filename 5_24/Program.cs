using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jeikhun = new Person("Jeikhun", "Jalilov", 20);
            Console.WriteLine(Jeikhun.IsAdult);
        }
    }
}