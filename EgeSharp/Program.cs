using EgeSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MertSharp
{

    class MyProgram
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>
            {
                new Employee(1,"Efe",1000),
                new Employee(2,"Ege",2000),
                new Employee(3,"Mert",3000),
                new Employee(4,"Fırat",4000),
                new Employee(5,"Serhan",5000),
                new Employee(6,"Pınar",6000),
                new Employee(7,"Kamil",7000),
            };

            List<Product> products = new List<Product>
            {
                new Product(1,"Çikolata",3,1001,10),
                new Product(2,"Çizi",5,1002,110),
                new Product(3,"Hoşbeş",3,1003,140),
                new Product(4,"Popkek",3,10014,510),
                new Product(5,"Çokomel",3,100211,110),
                new Product(6,"Tutku",3,100231,130),
                new Product(7,"Milka",3,101301,101),
            };

            List<Sale> sales = new List<Sale>();

            int i = 1;
            while (true)
            {
                Console.WriteLine("----------------" + (i++) + ". satış -------- (Çıkış yapmak için 0 girin)");
                Console.WriteLine("Satış yapılacak ürün id si : ");
                int productId = Convert.ToInt32(Console.ReadLine());

                if (productId == 0)
                {
                    break;
                }

                Console.WriteLine("Satış yapılacak kişinin id si : ");
                int employeeId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kaç adet satıldı : ");
                int amount = Convert.ToInt32(Console.ReadLine());

                var employee = employees.FirstOrDefault(x => x.Id == employeeId);
                var product = products.FirstOrDefault(x => x.Id == productId);

                sales.Add(Sale.AddSale(employee, product, DateTime.Now, amount));

            }

            int m = 1;
            foreach (var sale in sales)
            {
                Console.WriteLine($"{m++}. satış : Kasiyer adı . {sale.Employee.Name} Ürün adı : {sale.Product.Name} " +
                    $"Tarih : {sale.Time} Adet : {sale.Amount}");
            }


        }

    }


}