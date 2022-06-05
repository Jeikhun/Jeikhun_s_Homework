using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Employee
    {
        
        public string Name;
        public string Surname;
        public int Salary;
        public int Experience;
        public bool HasBachelorDegree;
        public Employee(string name,string surname,int salary,int experience,bool bachelordegree )
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Experience = experience;
            HasBachelorDegree = bachelordegree;
        }

        public Employee()
        {

        }



    }
}
