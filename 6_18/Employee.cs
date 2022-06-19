using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private static int _id;
        public Employee(string name)
        {
            Name = name;
            Id = ++_id;
        }

    }
}
