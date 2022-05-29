using System;

namespace ConsoleApp13
{
    public class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("Username daxil edin");
            string Username=Console.ReadLine();
            Console.WriteLine("Password daxil  edin");
            string Password=Console.ReadLine();

            User Jeikhun = new Student()
            {
                Name = "Jeikhun",
                Surname = "Jalilov",
                Username = "ceyhunjalil",
                Password = "ceyhun2002",
                Grade = 97
            };

            User Xasay = new User()
            {
                Name = "Xasay",
                Surname = "Musayev",
                Username = "xasayum",
                Password = "xasay2002",
                
            };

            User Cavid = new Student()
            {
                Name = "Cavid",
                Surname = "Ibrahimli",
                Username = "cavidabraham",
                Password = "cavid2002",
                Grade = 100
            };

            User Emrah = new User()
            {
                Name = "Emrah",
                Surname = "Soltanov",
                Username = "emrahsoltan",
                Password = "emrah2002"
            };

            User[] users = {Jeikhun, Xasay, Emrah, Cavid}; 
            foreach (var user in users)
            {
                if (Username == user.Username && Password==user.Password)
                {
                    counter++;
                    user.PrintGrade();
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Username yaxud shifre yanlishdir");
                return;
            }
        }
    }
}
