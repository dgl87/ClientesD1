using Clientes.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class CustomersRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public CustomerStatus Status { get; set; }
        public Customers Customers { get; set; }

        public CustomersRecord()
        {
        }

        public CustomersRecord(DateTime date, double amount, CustomerStatus status, Customers customers)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Customers = customers;
        }
    }
}
