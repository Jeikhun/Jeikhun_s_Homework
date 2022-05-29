using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class User
    {
        public string Name;
        public string Surname;
        public string Username;
        public string Password;
        public virtual void PrintGrade()
        {
            Console.WriteLine("Siz telebe deyilsiniz");
        }
    }
}
