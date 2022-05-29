using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Student:User
    {
        public int Grade;

        public override void PrintGrade()
        {
            Console.WriteLine(Grade);
        }
    }
}
