using System.Collections.Generic;

namespace Clientes.Models.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customers Customers { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
