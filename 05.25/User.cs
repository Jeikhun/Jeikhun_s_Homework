using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Name;
        public string Surname;
        public string Username;
        public string Password;
        public User(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }
        public virtual void WhoIs()
        {
            Console.WriteLine("Bu istifadeci sagird deyil");
        }
    }
}