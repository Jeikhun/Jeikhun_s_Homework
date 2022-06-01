using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Student
    {
        public int Age;
        public static int _age;
        public Student()
        {
            _age++;
            Age = _age;

        }
    }
}
