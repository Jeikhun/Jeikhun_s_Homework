using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Student
    {
        public void SetGrade(int[] grade)
        {
            foreach (var item in grade)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
