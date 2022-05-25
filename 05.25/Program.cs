using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Username qeyd edin");
            string username = Console.ReadLine();

           
            
            
            Console.WriteLine("Password qeyd edin");
            string password = Console.ReadLine();

            User[] users = { new Student("Tural", "Ismayilov", "turalismylv", "tural123", "A"),
                             new Student("Murad", "Alcanov", "muradacn", "murad123", "B"),
                             new User("Emil", "Quluzade", "emilquluzade", "emil123") };




            bool flag = false;
            foreach (var item in users)
            {
                if (username == item.Username && password == item.Password)
                {
                    flag = true;
                    item.WhoIs();

                }
            }
            if (!flag) Console.WriteLine("Bu username ve passwordda User yoxdur!");
        }
    }
}