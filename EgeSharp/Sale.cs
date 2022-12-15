using System;
using System.Collections.Generic;
using System.Text;

namespace EgeSharp
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Time { get; set; }
        public int Amount { get; set; }

        public Employee Employee { get; set; }
        public Product Product { get; set; }


        public static Sale AddSale(Employee employee , Product product , DateTime time , int amount)
        {
            return new Sale() { Id = employee.Id, ProductId = product.Id, EmployeeId = employee.Id, Time = time, Amount = amount , Employee = employee , Product = product };
        }


    }
}
