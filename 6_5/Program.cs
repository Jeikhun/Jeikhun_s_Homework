using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            Console.Write("Department Name:");
            department.Name = Console.ReadLine();
            //Isci limiti
            Console.Write("Employee Limit:");
            string limitstr = Console.ReadLine();
            bool limit = int.TryParse(limitstr, out int num);
            {
                while (!limit)
                {
                    Console.WriteLine("Zehmet olmazsa reqemi duzgun daxil edin");
                    limitstr = Console.ReadLine();
                    limit = int.TryParse(limitstr, out num);

                }
            }
            department.EmployeeLimit = num;
            //budce
            Console.Write("Budget:");
            string budgetstr = Console.ReadLine();
            bool budget = int.TryParse(budgetstr, out num);
            {
                while (!budget)
                {
                    Console.WriteLine("Zehmet olmazsa reqemi duzgun daxil edin");
                    budgetstr = Console.ReadLine();
                    budget = int.TryParse(budgetstr, out num);
                }
            }
            department.Budget = num;
            //tecrube
            Console.Write("Required Experience:");
            string dexperiencestr = Console.ReadLine();
            bool dexperience = int.TryParse(dexperiencestr, out num);
            {
                while (!dexperience)
                {
                    Console.WriteLine("Zehmet olmazsa reqemi duzgun daxil edin");
                    dexperiencestr = Console.ReadLine();
                    dexperience = int.TryParse(dexperiencestr, out num);
                }
            }
            department.RequiredExperience = num;
                tehsil:
            Console.WriteLine("Is Bachelor Degree Required:         (Yes/No)");
            string bachelordegree = Console.ReadLine();
            if (bachelordegree.ToUpper() == "YES")
            {
                department.IsBachelorDegreeRequired = true;
            }
            else if (bachelordegree.ToUpper() == "NO")
            {
                department.IsBachelorDegreeRequired = false;
            }
            else { Console.WriteLine("Yanlishdir"); goto tehsil; }
            string employeestr;
            Console.WriteLine("isci elave etmek isteyirinizmi     Yes/No");
            employeestr = Console.ReadLine();
            while (employeestr.ToUpper() == "YES")
            {
                Employee employee = new Employee();
                Console.Write("isci adini daxil edin:");
                employee.Name = Console.ReadLine();
                Console.Write("isci soyadini daxil edin:");
                employee.Surname = Console.ReadLine();
                //maas
                Console.Write("iscinin maasini daxil  edin");
                string salarystr=Console.ReadLine();
                bool salary = int.TryParse(salarystr, out int numsalary);
                while (!salary)
                {
                    Console.WriteLine("zehmet olmazsa duzgun daxil edin:");
                    salarystr = Console.ReadLine();
                    salary = int.TryParse(salarystr, out numsalary);
                }employee.Salary = numsalary;
                //teccrube
                Console.Write("iscinin tecrubesini daxil edin");
                string experiencestr = Console.ReadLine();
                bool experience = int.TryParse(salarystr, out int numexperience);
                while (!experience)
                {
                    Console.WriteLine("zehmet olmazsa duzgun daxil edin:");
                    experiencestr = Console.ReadLine();
                    experience = int.TryParse(experiencestr, out numexperience);
                }employee.Experience = numexperience;
                Console.Write("iscinin ali tehsil derecesi varmi        Yes/No");
                     Bachelor:
                string bachelorstr = Console.ReadLine();

                if (bachelorstr.ToUpper() == "YES")
                {
                    employee.HasBachelorDegree = true;
                }
                else if (bachelorstr.ToUpper() != "YES") { employee.HasBachelorDegree = false; }
                else { Console.WriteLine("Duzgun daxil edin"); goto Bachelor; }

            }
            if (employeestr.ToUpper() == "NO")
            {

            }
        }
    }
}

