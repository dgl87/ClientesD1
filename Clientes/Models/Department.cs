using System;
using System.Collections.Generic;
using System.Linq;

namespace Clientes.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Customers> Customer { get; set; } = new List<Customers>();

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
        public void AddSeller(Customers seller)
        {
            Customer.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Customer.Sum(Customer => Customer.TotalSales(initial, final));
        }
    }
}
