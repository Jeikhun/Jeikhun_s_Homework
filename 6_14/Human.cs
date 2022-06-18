using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Human(string name)
        {
            Name = name;
        } 
    }
    class Student : Human
    {

        public double Grade { get; set; }
        public Student(double grade, string name ) : base(name)
        {
            Grade = grade;

        }



       
    }
    class Employee : Human
    {
        public string Position { get; set; }
        public Employee(string name, string position) : base(name)
        {
            Position = position;
        }
    }
}
