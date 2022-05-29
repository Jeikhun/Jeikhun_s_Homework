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

            User[] users = { new Student("Jeikhun", "Jalilov", "ceyhunjalil", "jyhun267", "A"),
                             new Student("Ali", "Veliyev", "vlyvali", "ali348", "B"),
                             new User("Xasay", "Musayev", "xsymsyv", "xsy893") };




            bool flag = false;
            foreach (var item in users)
            {
                if (username == item.Username && password == item.Password)
                {
                    flag = true;
                    item.WhoIs();

                }
            }
            if (!flag) Console.WriteLine("Bu username ve passwordda User yoxdur...");
        }
    }
}
