using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        private static int _id;
        public List<Book> books;
        public Author(string name, string surname)
        {
            Name = name;
            Id = ++_id;
            Surname = surname;
            books = new List<Book>();
        }
    }
}
