using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Structures
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Employee()
        {
            Name = "No name";
            Surname = "No surname";
            Salary = 0;
            BirthDate = DateTime.Now;
        }

        public Employee(string n, string sn, decimal s, DateTime date)
        {
            Name = n;
            Salary = s;
            Surname = sn;
            BirthDate = date;
        }

        public override string ToString()
        {
            return $"Name: {Name} {Surname}" +
                   $"\nSalary: {Salary}" +
                   $"\nBirtgday: {BirthDate.ToShortDateString()}";
        }
    }
}
