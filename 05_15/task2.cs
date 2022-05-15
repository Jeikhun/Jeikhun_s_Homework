using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine(PrintStar(4,6,7,9));
        }

        static string PrintStar(params int[] arr )
        {
            int sum=0;
            for(int i= 0; i < arr.Length; i++)
            {
                sum+=arr[i];
            }
            if (sum % 2 == 0)
            {
                return "Cem 2e bolunur";
            }
            else
            {
                return "cem 2e bolunmur";
            }           
        }
    }
}
