using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Structures
{
    enum CategoryType
    {
        dairyProducts, groceries, vegetables, fruits, householdGoods
    };


    struct Product
    {
        private readonly DateTime manufactureDate;
        public DateTime CreateDate { get => manufactureDate; }

        public string Name { get; set; }
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        public Product(string n, decimal p, CategoryType c)
        {
            Name = n;
            Price = p;
            Category = c;
            manufactureDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nCategory: " +
                   $"{Category}\nPrice: {Price}\n" +
                   $"{manufactureDate.ToString()}";
        }
    };

    class Program
    {
        static Factory CreateNewFactory()
        {

            Console.Write("Enter factory name: ");
            string factoryName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter count of employees: ");
            string useString = Console.ReadLine();
            int emplCount = Convert.ToInt32(useString);
            Console.WriteLine();

            Console.Write("Enter count of products: ");
            useString = Console.ReadLine();
            int prodlCount = Convert.ToInt32(useString);
            Console.WriteLine();

            Employee[] arrEmp = new Employee[emplCount];
            for (int i = 0; i < emplCount; i++)
            {
                Console.Write("Enter employee's name: ");
                string emplName = Console.ReadLine();

                Console.Write("Enter employee's surname: ");
                string emplSurName = Console.ReadLine();

                Console.Write("Enter employee's salary: ");
                useString = Console.ReadLine();
                int emplSalary = Convert.ToInt32(useString);

                Console.WriteLine("Enter employee's birthday:");
                Console.Write("day - ");
                useString = Console.ReadLine();
                int day = Convert.ToInt32(useString);

                Console.Write("month: - ");
                useString = Console.ReadLine();
                int month = Convert.ToInt32(useString);

                Console.Write("year: - ");
                useString = Console.ReadLine();
                int year = Convert.ToInt32(useString);

                arrEmp[i] = new Employee(emplName, emplSurName, emplSalary, new DateTime(year, month, day));
                Console.WriteLine();
            }

            Product[] arrProd = new Product[prodlCount];

            for (int i = 0; i < prodlCount; i++)
            {
                Console.Write("Enter products's name: ");
                string prodName = Console.ReadLine();

                Console.Write("Enter products's price:");
                useString = Console.ReadLine();
                int prodPrice = Convert.ToInt32(useString);

                Console.WriteLine(); 
                Console.Write("Select product's category:\n1.DairyProducts" +
                    "\n 2. Groceries\n3. Vegetables\n4. Fruits\n 5.HouseholdGoods");

                Console.WriteLine();
                Console.Write("Enter number: ");
                useString = Console.ReadLine();
                int categoryType = Convert.ToInt32(useString);

                CategoryType type;
               
                switch (categoryType)
                {
                    case 1:
                        type = CategoryType.dairyProducts;
                        break;
                    case 2:
                        type = CategoryType.groceries;
                        break;
                    case 3:
                        type = CategoryType.vegetables;
                        break;
                    case 4:
                        type = CategoryType.fruits;
                        break;
                    case 5:
                        type = CategoryType.householdGoods;
                        break;
                    default:
                        throw new Exception("Error! Invalid number!");
                }

                arrProd[i] = new Product(prodName, prodPrice, type);
                Console.WriteLine();
                Console.WriteLine();
            }

            return new Factory(factoryName, arrEmp, arrProd);

        }

        static void Main(string[] args)
        {
            Factory newFactory;
       
            try
            {
                newFactory = CreateNewFactory();
                newFactory.ShowListEmployees();
                Console.WriteLine();

                newFactory.ShowListProducts();
                Console.WriteLine();

                Console.WriteLine(newFactory.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
