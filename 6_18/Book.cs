using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Book
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        private static int _id;
        public int Page { get; set; }
        public List<Author> authors;
        public Book(string name, int page, string type)
        {
            Id = ++_id;
            Name = name;
            Page = page;
            authors = new List<Author>();
            Type = type;
        }
    }
}
