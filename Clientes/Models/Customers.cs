using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Clientes.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")] //Determina nome com 3 - 60
        public string Name { get; set; }        

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }                
        public string Contacts { get; set; }
        public string Adress { get; set; }
        public string RedesSociais { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<CustomersRecord> Sales { get; set; } = new List<CustomersRecord>();

        public Customers()
        {
        }

        public Customers(string name, DateTime birthDate, string contacts, string adress, string redesSociais, int cPF, int rG, Department department)
        {
            Name = name;
            BirthDate = birthDate;
            Contacts = contacts;
            Adress = adress;
            RedesSociais = redesSociais;
            CPF = cPF;
            RG = rG;
            Department = department;
        }
        public void AddCustomers(CustomersRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveCustomers(CustomersRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
