using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStar(6);
        }
        static void PrintStar(int hundurluk)
        {
           
            for(int i = 0; i < hundurluk; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
