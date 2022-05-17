using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nurlan Faiq Emil Tural Yusif";
            Console.WriteLine(Revers(name));
        }

        static string Revers(string name)
        {
            string reversedName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedName += name[i];

            }
            return reversedName;
        }
    }
}
