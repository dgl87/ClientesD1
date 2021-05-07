using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clientes.Models;

namespace Clientes.Data
{
    public class ClientesContext : DbContext
    {
        public ClientesContext (DbContextOptions<ClientesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomersRecord> CustomersRecord { get; set; }
    }
}
