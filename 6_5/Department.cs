using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Department
    {
        public string Name;
        public int EmployeeLimit; // departmentin umumi ala bileceyi isci sayi
        public int Budget; // departmentin umumi budcesi
        public int RequiredExperience; // departmentin iscilerinin en az nece il tecrubesi olmali oldugunu gosterir
        public bool IsBachelorDegreeRequired; // departmentin iscileri ucun ali tehsilin vacib olub olmamasini gosterir
        Employee[] employees = new Employee[0];
        public Department()
        {
        }
        public Department(string name, int employeelimit, int budget, int requiredexperience, bool isbachelordegreerequired) : this()
        {

            Name = name;
            EmployeeLimit = employeelimit;
            Budget = budget;
            RequiredExperience = requiredexperience;
            IsBachelorDegreeRequired = isbachelordegreerequired;

        }
        public bool AddEmployee(Employee employee)
        {

            if (employee.Experience >= RequiredExperience && employee.HasBachelorDegree == IsBachelorDegreeRequired)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                int sum = 0;
                foreach (var ep in employees)
                {
                    sum += ep.Salary;
                }
                if (EmployeeLimit >= employees.Length && sum <= Budget)
                {
                    return true;
                }
            }

            return false;
        }
        public void Ortalama()
        {
            int cem = 0;

            foreach (var item in employees)
            {
                cem += item.Salary;
            }

            int count = employees.Length;
            Console.WriteLine($"Umumi maas ortalamasi :{cem / count}", ConsoleColor.Blue);
        }
    }

}
