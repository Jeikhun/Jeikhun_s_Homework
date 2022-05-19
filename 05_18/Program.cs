using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr1 = { 2, 3, 4, 7 };
            int [] arr2 = { 2, 3, 4 };
            Console.WriteLine(IsArrayContains(arr1, arr2));
        }
        static bool IsArrayContains( int[] arr1, int[] arr2)
        {
            string str1 = string.Join(" ", arr1);
            string str2 = string.Join(" ", arr2);
            if(str1.Contains(str2)){
                return true;
            }else
                return false;
        } 
        
    }
}
