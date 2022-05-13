using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine( IsPrime(2));
        }
        


        static bool IsPrime(int a)
        {
            bool flag = false;
            if(a%a==0 && a % 1 == 0)
            {
                flag = true;
            }
            if (a % 2 == 0 && a>2 || a % 3 == 0 && a>3)
            {
                flag = false;
            }return flag;



        }
    }
}
