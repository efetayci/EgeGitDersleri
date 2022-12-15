using System;
using System.Collections.Generic;
using System.Text;

namespace EgeSharp
{
    public class Employee
    {
        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
