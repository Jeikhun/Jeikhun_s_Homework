using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Person
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsAdult = true;
            if (age < 18)
            {
                IsAdult = false;
            }
        }
        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;
    }
}