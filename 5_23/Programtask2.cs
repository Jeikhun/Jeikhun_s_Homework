using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Salam", "iki", "saqol" };
            Method(arr, 'c');
        }

        static void Method(string[] arr, char ch)
        {
            int counter=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(ch))
                {
                    counter++;
                    Console.WriteLine(arr[i]);
                }     
            }   if(counter == 0)
            {
                Console.WriteLine("Netice yoxdur");
            }
        }
    }
}

