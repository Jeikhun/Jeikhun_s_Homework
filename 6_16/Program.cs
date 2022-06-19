using System;
using System.Collections.Generic;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("CodeAcademy");
        Menu:
            Helper.PrintLine("1.Qrup elave et: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("2.Qruplari gor: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("3.Qrupa student elave et: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("4.Studentleri gor: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("5.Studentler uzre axtarish et: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("6. Qrupdan student sil: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("7. Qrupdaki studenti editle: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("8. Studentin butun melumatlarini goster: ", ConsoleColor.DarkYellow);
            string chosemenu = Console.ReadLine();
            switch (chosemenu)
            {
                case "1":
                    Helper.PrintLine("Qrup adi daxil edin ", ConsoleColor.Cyan);
                GroupName:
                    string nameOfGroup = Console.ReadLine();
                    foreach (var item in course.groups)
                    {
                        if (item.Name == nameOfGroup)
                        {
                            Helper.Print("Bu adla qrup movcuddur, yeniden daxil et: ", ConsoleColor.Red);
                            goto GroupName;
                        }
                    }
                    Group group = new Group(nameOfGroup);
                    course.groups.Add(group);
                    Helper.PrintLine($"{nameOfGroup} qrupu ugurla elave edildi ", ConsoleColor.Green);

                    goto Menu;
                case "2":

                    foreach (var item in course.groups)
                    {
                        Helper.PrintLine(item.Name, ConsoleColor.Blue);

                    }
                    Helper.PrintLine("Qruplari movcuddur", ConsoleColor.DarkGreen);
                    goto Menu;
                case "3":
                    Helper.PrintLine("Telebenin adini daxil edin", ConsoleColor.DarkYellow);
                    string studentname = Console.ReadLine();
                    Helper.PrintLine("Telebenin soyadini daxil edin", ConsoleColor.DarkYellow);
                    string studentsurname = Console.ReadLine();
                    Helper.PrintLine("Telebenin yasini daxil edin", ConsoleColor.DarkYellow);
                    string studentagestr = Console.ReadLine();
                    bool isstudentage = int.TryParse(studentagestr, out int studentage);
                    if (!isstudentage)
                    {
                        Helper.PrintLine("Telebenin yasini duzgun daxil edin", ConsoleColor.Red);
                        goto case "3";
                    }
                StudentGrade:
                    Helper.PrintLine("Telebenin balini daxil edin", ConsoleColor.DarkYellow);
                    string studentgradestr = Console.ReadLine();
                    bool isstudentgrade = double.TryParse(studentgradestr, out double studentgrade);
                    if (!isstudentgrade || studentgrade > 100 || studentgrade < 0)
                    {
                        Helper.PrintLine("Telebenin balini duzgun daxil edin", ConsoleColor.Red);
                        goto StudentGrade;
                    }
                    Student student = new Student(studentname, studentsurname, studentage, studentgrade);
                    foreach (var item in course.groups)
                    {
                        Helper.PrintLine(item.Name, ConsoleColor.Blue);
                    }
                    Helper.PrintLine("Qruplari movcuddur", ConsoleColor.DarkGreen);
                Groupstr:
                    Helper.PrintLine("Elave edilmesini istediyiniz qrupun adini qeyd edin", ConsoleColor.DarkGreen);
                    string groupstr = Console.ReadLine();
                    foreach (var item in course.groups)
                    {
                        if (groupstr == item.Name)
                        {
                            item.students.Add(student);
                        }
                    }
                    Helper.PrintLine($"{groupstr} qrupuna {studentname} adli telebe ugurla elave edildi", ConsoleColor.Green);
                    goto Menu;
                case "4":
                    foreach (var item in course.groups)
                    {
                        Helper.PrintLine(item.Name, ConsoleColor.Magenta);
                    }
                Chosegroupname:
                    Helper.PrintLine("Telebelerini gormek istediyiniz qrupun adini daxil edin", ConsoleColor.DarkYellow);
                    string chosegroupname = Console.ReadLine();
                    foreach (var item in course.groups)
                    {
                        if (item.Name == chosegroupname)
                        {
                            foreach (var item2 in item.students)
                            {
                                Helper.PrintLine(item2.Name, ConsoleColor.Magenta);
                            }
                        }
                        else
                        {
                            Helper.PrintLine("Bu adli qrup yoxdur tekrar qeyd edin", ConsoleColor.Red);
                            goto Chosegroupname;
                        }
                    }
                    Helper.PrintLine("Telebeleri movcuddur", ConsoleColor.Green);
                    goto Menu;
                case "5":
                GoFindstudent:
                    Helper.PrintLine("Axtardiginiz telebenin adini daxil edin", ConsoleColor.Cyan);
                    string FindStudent = Console.ReadLine();
                    foreach (var item in course.groups)
                    {
                        foreach (var item1 in item.students)
                        {
                            if (item1.Name.Contains(FindStudent))
                            {
                                Helper.PrintLine("Axtardiginiz telebe " + item1.Name, ConsoleColor.Green);
                            }
                            else
                            {

                                Helper.PrintLine("Bele telebe movcud deyil ", ConsoleColor.Red);
                                goto GoFindstudent;
                            }
                        }
                    }
                    goto Menu;
                case "6":
                    foreach(var item in course.groups)
                    {
                        Helper.PrintLine("Qrupun adi-- "+item.Name, ConsoleColor.DarkYellow);
                    }
                    Helper.PrintLine("Silmek istediyiniz qrupun adini daxil edin ", ConsoleColor.DarkYellow);
                    string groupname = Console.ReadLine();
                    foreach(var item in course.groups)
                    {
                        if (item.Name == groupname)
                        {
                            foreach(var item1 in item.students)
                            {
                                Helper.PrintLine("Qrupdaki telebenin Id-i:  "+ item1.Id + "  Adi:  " + item1.Name, ConsoleColor.Cyan);
                            }
                        }
                    }
                    inputID:
                    Helper.PrintLine("Silmek istediyiniz telebenin Id-ni daxil edin ", ConsoleColor.DarkYellow);
                    string removestudentid = Console.ReadLine();
                    bool isremovestudentid = int.TryParse(removestudentid, out int studentid);
                    if (!isremovestudentid)
                    {
                        Helper.PrintLine("Duzgun ID daxil edin ", ConsoleColor.Red);
                    }
                    foreach (var item in course.groups)
                    {
                        if (item.Name == groupname)
                        {
                            foreach (var item1 in item.students)
                            {
                                if (studentid == item1.Id)
                                {
                                    item.students.Remove(item1);
                                    Helper.PrintLine("Telebe ugurla silindi ", ConsoleColor.Green);
                                    goto Menu;
                                }
                                else
                                {
                                    Helper.PrintLine("Axtardiginiza uygun telebe yoxdur ", ConsoleColor.Red);
                                    goto inputID;
                                }
                            }
                        }
                    }goto Menu;
                case "7":
                    foreach (var item in course.groups)
                    {
                        Helper.PrintLine("Qrupun adi-- " + item.Name, ConsoleColor.DarkYellow);
                    }
                    Helper.PrintLine("Editlemek istediyiniz qrupun adini daxil edin ", ConsoleColor.DarkYellow);
                    string editgroupname = Console.ReadLine();
                    foreach (var item in course.groups)
                    {
                       if(editgroupname == item.Name)
                        {
                            foreach (var item1 in item.students)
                            {
                                Helper.PrintLine("Telebe id "+ item1.Id+ " Adi " + item1.Name, ConsoleColor.Blue);
                            }
                        }
                    }
                    editid:
                    Helper.PrintLine("Editlemek istediyiniz studentin id-ni daxil edin ", ConsoleColor.DarkYellow);
                    string editidstr = Console.ReadLine();
                    bool iseditid = int.TryParse(editidstr, out int editid);
                    if (!iseditid)
                    {
                        Helper.PrintLine("Duzgun id daxil edin ", ConsoleColor.Red);
                        goto editid;
                    }
                    Menu2:
                    Helper.PrintLine("1.Studentin adini deyisdir ", ConsoleColor.DarkYellow);
                    Helper.PrintLine("2.Studentin soyadini deyisdir ", ConsoleColor.DarkYellow);
                    Helper.PrintLine("3.Studentin yasini deyisdir ", ConsoleColor.DarkYellow);
                    Helper.PrintLine("4.Studentin balini deyisdir ", ConsoleColor.DarkYellow);
                    Helper.PrintLine("5.Esas menuya qayit ", ConsoleColor.DarkYellow);
                    string chosemenu2 = Console.ReadLine();
                    switch (chosemenu2)
                    {
                        case "1":

                            Helper.PrintLine("Yeni ad daxil edin ", ConsoleColor.DarkYellow);
                            string newnamee = Console.ReadLine();
                            foreach(var item in course.groups)
                            {
                                if (editgroupname == item.Name)
                                {
                                    foreach (var item1 in item.students)
                                    {
                                        if(editid == item1.Id)
                                        {
                                            item1.Name = newnamee;
                                        }
                                    }

                                }
                            }
                            goto Menu2;
                        case "2":
                            Helper.PrintLine("Yeni soyad daxil edin ", ConsoleColor.DarkYellow);
                            string newsurname = Console.ReadLine();
                            foreach (var item in course.groups)
                            {
                                if (editgroupname == item.Name)
                                {
                                    foreach (var item1 in item.students)
                                    {
                                        if (editid == item1.Id)
                                        {
                                            item1.Surname = newsurname;
                                        }
                                    }

                                }
                            }
                            goto Menu2;
                        case "3":
                            newAge:
                            Helper.PrintLine("Yeni yas daxil edin ", ConsoleColor.DarkYellow);
                            string newagestr = Console.ReadLine();
                            bool isnewage = int.TryParse(newagestr, out int newage);
                            if (!isnewage)
                            {
                                Helper.PrintLine("Duzgun yas daxil edin ", ConsoleColor.DarkRed);
                                goto newAge;
                            }
                            foreach (var item in course.groups)
                            {
                                if (editgroupname == item.Name)
                                {
                                    foreach (var item1 in item.students)
                                    {
                                        if (editid == item1.Id)
                                        {
                                            item1.Age = newage;
                                        }
                                    }

                                }
                            }
                            goto Menu2;
                        case "4":
                        newGrade:
                            Helper.PrintLine("Yeni bal daxil edin ", ConsoleColor.DarkYellow);
                            string newgradestr = Console.ReadLine();
                            bool isnewgrade = double.TryParse(newgradestr, out double newgrade);
                            if (!isnewgrade)
                            {
                                Helper.PrintLine("Duzgun bal daxil edin ", ConsoleColor.DarkRed);
                                goto newGrade;
                            }
                            foreach (var item in course.groups)
                            {
                                if (editgroupname == item.Name)
                                {
                                    foreach (var item1 in item.students)
                                    {
                                        if (editid == item1.Id)
                                        {
                                            item1.Grade = newgrade;
                                        }
                                    }

                                }
                            }
                            goto Menu2;
                        case "5":
                            goto Menu;

                    }goto Menu;
                case "8":
                    Helper.PrintLine("Telebenin adini daxil edin ", ConsoleColor.DarkYellow);
                    string findstudent = Console.ReadLine();
                    foreach(var item in course.groups)
                    {
                        foreach(var item1 in item.students)
                        {
                            if(findstudent == item1.Name)
                            {
                                Helper.PrintLine("Telebenin adi: " + item1.Name + " Telebenin soyadi:  " + item1.Surname + " Telebenin yasi " + item1.Age + " Telebenin bali " + item1.Grade, ConsoleColor.DarkYellow);
                            }
                        }
                    }

                    goto Menu;
                default:
                    Helper.PrintLine("Duzgun secim daxil edin ", ConsoleColor.Red);
                    goto Menu;
            }
        }
    }
    class Course
    {
        public string Name { get; set; }
        public List<Group> groups = new List<Group>();
        public Course(string name)
        {
            Name = name;
        }
    }

    class Group
    {
        public string Name { get; set; }
        public List<Student> students = new List<Student>();
        public Group(string name)
        {
            Name = name;
        }

    }
    class Student
    {
        public int Id { get; set; }
        public static int _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public Student(string name, string surname, int age, double grade)
        {
            Id = _id++;
            Name = name;
            Age = age;
            Surname = surname;
            Grade = grade;

        }
    }

}
