using System;

namespace Taskk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 1, 9, 4, 8 };

            Sort(arr);
        }

        static void Sort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j =i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                       
                    }
                    


                }
            }
            foreach (int k in arr)
            {

                Console.WriteLine(k + " ");
            }
        }
    }
}
