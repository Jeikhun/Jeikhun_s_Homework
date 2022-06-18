using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            List<Employee> emps = new List<Employee>();
            Menu:
           Helper.PrintLine("1. Student elave et.", ConsoleColor.Cyan);
           Helper.PrintLine("2. Employee elave et.", ConsoleColor.Cyan);
           Helper.PrintLine("3. Axtarish et.", ConsoleColor.Cyan);
           Helper.PrintLine("4. Cixish menusu gelsin. ", ConsoleColor.Cyan);
            string chosemenu = Console.ReadLine();
            switch (chosemenu)
            {
                case "1":
                    Helper.PrintLine("Zehmet olmazsa ad daxil edin", ConsoleColor.DarkYellow);
                    string name = Console.ReadLine();
                    Helper.PrintLine("Zehmet olmazsa Bal daxil edin", ConsoleColor.DarkYellow);
                     Grade:
                    string gradestr = Console.ReadLine();
                    bool bgrade = double.TryParse(gradestr,out double grade);
                    if (!bgrade || grade >100 || grade<0)
                    {
                        Helper.PrintLine("Zehmet olmazsa ededi duzgun daxil edin", ConsoleColor.Red);
                        goto Grade;
                    }Student student = new Student(grade, name);
                    students.Add(student);
                    Helper.PrintLine("Tebrikler telebe elave edildi", ConsoleColor.Green);
                    goto Menu;

                case "2":
                    Helper.PrintLine("Zehmet olmazsa iscinin adini daxil edin", ConsoleColor.DarkYellow);
                    string empname = Console.ReadLine();
                    Helper.PrintLine("Zehmet olmazsa iscinin vezifesini daxil edin", ConsoleColor.DarkYellow);
                    string position = Console.ReadLine();
                    Employee emp = new Employee(empname, position);
                    emps.Add(emp);
                    Helper.PrintLine("Tebrikler isci elave edildi", ConsoleColor.Green);
                    goto Menu;

                case "3":
                    SecondMenu:
                    Helper.PrintLine("1.Employee uzre axtarish", ConsoleColor.DarkYellow);
                    Helper.PrintLine("2.Student uzre axtarish", ConsoleColor.DarkYellow);
                    string chosesearch = Console.ReadLine();
                    if (chosesearch == "1")
                    {

                        Helper.PrintLine("Axtardiginiz isciniz vezifesini daxil edin", ConsoleColor.DarkMagenta);
                        Searchemp:
                        string searchemp = Console.ReadLine();
                        foreach (var item in emps)
                        {
                            if (item.Position.ToUpper().Contains(searchemp.ToUpper()))
                            {
                                Helper.PrintLine( "Axtardiginiz Isci => " + item.Name, ConsoleColor.Green);
                                goto SecondMenu;
                            }
                            else
                            {
                                Helper.PrintLine("Bele bir isci movcud deyil yaxud sehv daxil etmisiniz", ConsoleColor.Red);
                                goto Searchemp;
                            }
                        }
                            
                    }
                    else if(chosesearch=="2")
                    {
                        Helper.PrintLine("Axtardiqiniz telebenin qiymet araliqini daxil etmelisiniz", ConsoleColor.DarkYellow);
                        Helper.Print("Minimum qiymeti daxil edin", ConsoleColor.DarkYellow);
                        MinGrade:
                        string mingradestr = Console.ReadLine();
                        bool bmingrade = double.TryParse(mingradestr, out double mingrade);
                        if(!bmingrade || mingrade<0 || mingrade>100)
                        {
                            Helper.PrintLine("Qiymeti duzgun daxil edin ", ConsoleColor.Red);
                            goto MinGrade;
                        }
                        Helper.Print("Maximum qiymeti daxil edin ", ConsoleColor.DarkYellow);
                        MaxGrade:
                        string maxgradestr = Console.ReadLine();
                        bool bmaxgrade = double.TryParse(maxgradestr, out double maxgrade);
                        if(!bmaxgrade || maxgrade<0 || maxgrade>100)
                        {
                            Helper.PrintLine("Qiymeti duzgun daxil edin", ConsoleColor.Red);
                            goto MaxGrade;
                        }
                        foreach(var item in students)
                        {
                            if (item.Grade<maxgrade && item.Grade>mingrade)
                            {
                                Helper.PrintLine("Axtardiginiz telebenin adi: " + item.Name + " " +
                                    "Topladigi bal: " + item.Grade, ConsoleColor.Green);
                                goto Menu;
                            }
                        }

                    }

                    break;

                case "4":

                    break;

                default:
                    Helper.PrintLine("Duzgun secim edin" , ConsoleColor.DarkRed);
                    goto Menu;
            }


        }


    }
}
