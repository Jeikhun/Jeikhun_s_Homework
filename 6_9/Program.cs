using System;
using System.Collections;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(6);
            array.Add(4);
            array.Add(1);
            array.Add(2);
            array.Add(9);
            array.Add(8);
            array.Add(6);
            array.Add(3);

            foreach (int i in array)
            {
                Console.WriteLine(i);   
            }
        }

        class CustomArrayList
        {

            public int Capacity { get; set; }
            public int Count { get; set; }
            public CustomArrayList(int capacity)
            {
                Capacity = capacity;

            }

            public void Add(object value)
            {

            }
            public void Remove()
            {

            }
            public void Removeat()
            {

            }
            public void TrimToSize()
            {

            }
            public void AddRange()
            {

            }

        }
    }
}
