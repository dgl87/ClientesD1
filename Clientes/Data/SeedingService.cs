using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clientes.Models;
using Clientes.Models.Enums;

namespace Clientes.Data
{
    public class SeedingService
    {
        private ClientesContext _context;

        public SeedingService(ClientesContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Customers.Any() ||
                _context.CustomersRecord.Any())
            {
                return; //DB has been seeded
            }
            Department d1 = new Department("Computers");
            Department d2 = new Department("Eletronics");
            Department d3 = new Department("Fashion");
            Department d4 = new Department("Books");

            Customers s1 = new Customers("Bob Brown", new DateTime(1998, 4, 21), "955554444", "Ribeirão Preto - SP", "Facebook/Bob", 654987857, 542154548, d1);
            Customers s2 = new Customers("Maria Green", new DateTime(1987, 7, 15), "966448877", "Santos - SP", "Facebook/Maria", 987653219, 343434343, d2);
            Customers s3 = new Customers("Alex Grey", new DateTime(1990, 2, 12), "987877878", "São Paulo - SP", "Facebook/Alex", 0123456789, 23412341, d1);
            Customers s4 = new Customers("Martha Red", new DateTime(1988, 8, 28), "945138357", "Itu - SP", "Facebook/Martha", 432098765, 14329776, d4);
            Customers s5 = new Customers("Donald Blue", new DateTime(1983, 11, 10), "945448965", "Guarulhos - SP", "Facebook/Donald", 109876543, 45345345, d3);
            Customers s6 = new Customers("Alex Pink", new DateTime(1978, 9, 27), "987543698", "Santo André - SP", "Facebook/Alex", 555555555, 87986456, d2);

            CustomersRecord r1 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s1);
            CustomersRecord r2 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s2);
            CustomersRecord r3 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s3);
            CustomersRecord r4 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s4);
            CustomersRecord r5 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s5);
            CustomersRecord r6 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s6);
            CustomersRecord r7 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s1);
            CustomersRecord r8 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s2);
            CustomersRecord r9 = new CustomersRecord(new DateTime(2018, 09, 25), 11000.0, CustomerStatus.Billed, s3);
           

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Customers.AddRange(s1, s2, s3, s4, s5, s6);
            _context.CustomersRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9
                );
            _context.SaveChanges();
        }
    }
}
