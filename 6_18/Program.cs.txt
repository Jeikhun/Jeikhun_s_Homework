using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("DelfinKitab");
            Menu:
            Helper.PrintLine("1. Kitabxanaya isci elave et: ", ConsoleColor.DarkYellow);
            Helper.PrintLine("2. Muellif elave et: ", ConsoleColor.DarkYellow );
            Helper.PrintLine("3. Kitabxanaya kitab elave et: ", ConsoleColor.DarkYellow );
            Helper.PrintLine("4. Kitabxanadan isci sil: ", ConsoleColor.DarkYellow );
            Helper.PrintLine("5. Kitabxanadan kitab sil: ", ConsoleColor.DarkYellow );


            string choseMenu = Console.ReadLine();
            switch (choseMenu)
            {
                case "1":
                    Helper.PrintLine("Iscinin adini daxil edin: ", ConsoleColor.Cyan);
                    string employeeName = Console.ReadLine();
                    Employee employee = new Employee(employeeName);
                    library.employees.Add(employee);
                    Helper.PrintLine($"{employee.Name} adli isci elave olundu", ConsoleColor.Green);
                    goto Menu;

                case "2":
                    Helper.PrintLine("Muellifin adini qeyd edin: ", ConsoleColor.Cyan);
                    string authorName = Console.ReadLine();
                    Helper.PrintLine("Muellifin soyadini qeyd edin: ", ConsoleColor.Cyan);
                    string authorSurname = Console.ReadLine();
                    Author author = new Author(authorName, authorSurname);
                    library.authors.Add(author);
                    Helper.PrintLine($"{author.Name} adli muellif elave olundu", ConsoleColor.Green);
                    goto Menu;

                case "3":
                    Helper.PrintLine("Kitabin adini daxil edin", ConsoleColor.Cyan);
                    string bookname = Console.ReadLine();
                    Helper.PrintLine("Kitabin novunu daxil edin", ConsoleColor.Cyan);
                    string bookType = Console.ReadLine();
                    Helper.PrintLine("Kitaba sehife sayi daxil edin", ConsoleColor.Cyan);
                    string bookPagestr  = Console.ReadLine();
                    int bookPage = int.Parse(bookPagestr);
                    Book book = new Book(bookname, bookPage, bookType);
                    foreach(var item in library.authors)
                    {
                        Console.WriteLine("Id--" + item.Id + " Name--" + item.Name);
                    }
                    Helper.PrintLine("Muellif yaxud muellifleri Id-e gore elave edin", ConsoleColor.Cyan);
                    string idstr = Console.ReadLine();
                    string[] idarr = idstr.Split(",");
                    int id;
                    foreach(var item in idarr)
                    {
                        id = int.Parse(item);
                        foreach(var item2 in library.authors)
                        {
                            if (id == item2.Id)
                            {
                                book.authors.Add(item2);
                                item2.books.Add(book);
                            }
                        }
                    }
                    library.books.Add(book);
                    Helper.PrintLine($"{book.Name } adli kitab yaradildi...", ConsoleColor.Green);

                    goto Menu;

                case "4":
                    foreach(var item in library.employees)
                    {
                        Helper.PrintLine("Iscinin Id--" + item.Id + " Iscinin adi--" + item.Name);
                    }
                    Helper.PrintLine("Silmek istediyiniz iscinin Id-ni daxil edin", ConsoleColor.Cyan);
                    string removeidstr = Console.ReadLine();
                    bool isremoveidstr = int.TryParse(removeidstr, out int removeid);
                    if (!isremoveidstr)
                    {
                        Helper.PrintLine("Duzgun ID daxil edin", ConsoleColor.Red);
                    }
                    foreach (var item in library.employees)
                    {
                        if (removeid == item.Id)
                        {
                            library.employees.Remove(item);
                            goto Menu;
                        }
                        else
                        {
                            Helper.PrintLine("Bu Id-de isci yoxdur, duzgun daxil edin", ConsoleColor.Red);
                        }
                    }
                    goto Menu;
                case "5":
                    foreach (var item in library.books)
                    {
                        Helper.PrintLine("Kitabin Id--" + item.Id + " Kitabin adi--" + item.Name);
                    }
                    Helper.PrintLine("Silmek istediyiniz kitabin Id-ni daxil edin", ConsoleColor.Cyan);
                    string removebookidstr = Console.ReadLine();
                    bool isremovebookidstr = int.TryParse(removebookidstr, out int removebookid);
                    if (!isremovebookidstr)
                    {
                        Helper.PrintLine("Duzgun ID daxil edin", ConsoleColor.Red);
                    }
                    foreach (var item1 in library.books)
                    {
                        if (removebookid == item1.Id)
                        {
                            library.books.Remove(item1);
                        }
                        else
                        {
                            Helper.PrintLine("Bu Id-de kitab yoxdur, duzgun daxil edin", ConsoleColor.Red);
                        }
                    }
                    goto Menu;
                default: Helper.PrintLine("Duzgun secim daxil edin", ConsoleColor.DarkRed);
                    goto Menu;
                    

                    
            }


        }
    }
}
