using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : User
    {
        public Student(string name, string surname, string username, string password, string grade)
            : base(name, surname, username, password)
        {
            Grade = grade;
        }
        public string Grade;
        public override void WhoIs()
        {

            Console.WriteLine($"Imtahan bali={Grade}");
        }
    }
}