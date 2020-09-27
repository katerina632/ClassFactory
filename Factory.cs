using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Structures
{
   partial class Factory
    {
        Employee[] employees;
        Product[] products;

        public string Name { get; set; }

        public Factory()
        {
            Name = "No name";
            employees = null;
            products = null;
        }

        public Factory(string h, Employee [] empl, Product [] prod)
        {
            Name = h;
            employees =empl;
            products = prod;              
        }

        public void ShowListEmployees() {

            Console.WriteLine("List of employees: ");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{i+1}) {employees[i].ToString()}");
            }
           // throw new Exception("List of employees is empty\n");
        }

        public void ShowListProducts()
        {
            Console.WriteLine("List ofproducts: ");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i+1}) {products[i].ToString()}");
            }
          //  throw new Exception("List of products is empty\n");

        }
        public override string ToString()
        {

            return $"Factory name: =={Name}==" +
                   $"\nAverage salary: {AvgSalary}" +
                   $"\nTotal salary: {TotalSalary}" +
                   $"\nGPD: {GDP}" +
                   $"\nEmployees count: {EmpCount}";
                   
                 
        }

    }
}
