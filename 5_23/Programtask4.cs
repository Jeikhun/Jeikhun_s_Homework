using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name = "Test",
                Email = "Eliyev",
                Username = "Testali",
                Password = "Test"
            };
        }

    }

    public class User
    {
        public string Name;
        public string Password;
        public string Email;
        public string PhoneNumber;
        public string Username;
        public string EmailAddress;

        public bool IsPasswordValid()
        {
            if (Password.Length < 6) { return false; }
            bool IsDigitIncluded=false;
            foreach (char item in Password)
            {
                if(int.TryParse(Password+"", out int result))
                {
                     IsDigitIncluded = true;
                    break;
                }
            }
            if (IsDigitIncluded == false) { return false; }

            int nameIndex = 0;
            int passIndex = 0;
            while (nameIndex < Name.Length)
            {
                if (Name[nameIndex] == Password[passIndex])
                {
                    nameIndex++;
                    passIndex++;
                    if(nameIndex== Name.Length)
                    {
                        return false;
                    }
                }
                else
                {
                    passIndex = passIndex - nameIndex + 1;
                    nameIndex = 0;
                }

            }
            return true;
        }
    }


}
