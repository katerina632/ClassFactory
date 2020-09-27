using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Structures
{
    partial class Factory
    {
        public decimal AvgSalary
        {
            get
            {
                decimal sum = 0;
                foreach (Employee item in employees)
                {
                    sum += item.Salary;
                }
                return sum / employees.Length;

                throw new Exception("Error!\n");
            }          

        }

        public decimal TotalSalary
        {
            get
            {
                decimal sum = 0;
                foreach (Employee item in employees)
                {
                    sum += item.Salary;
                }
                return sum;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal sum = 0;
                foreach (Product item in products)
                {
                    sum += item.Price;
                }
                return sum / products.Length;
                throw new Exception("Error!\n");
            }
        }

        public decimal EmpCount
        {
            get
            {
                return employees.Length;
            }
        }
    }
}
