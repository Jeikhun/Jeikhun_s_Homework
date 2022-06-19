using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Library
    {
        public string Name { get; set; }
        public List<Book> books;
        public List<Author> authors;
        public List<Employee> employees;

        public Library(string name) 
        {
            Name = name;
            books = new List<Book>();
            authors = new List<Author>();
            employees = new List<Employee>();
        }
    }
}
