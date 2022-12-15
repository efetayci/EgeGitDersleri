using System;
using System.Collections.Generic;
using System.Text;

namespace EgeSharp
{
    public class Product
    {
        public Product(int id , string name, double price , int barkod , int amount)
        {
            this.Id = id;
            this.Name = name;
            this.Amount = amount;
            this.Barkod = barkod;
            this.Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Barkod { get; set; }
        public int Amount { get; set; }
    }
}
