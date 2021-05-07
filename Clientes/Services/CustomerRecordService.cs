using Clientes.Data;
using Clientes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Services
{
    public class CustomerRecordService
    {
        private readonly ClientesContext _context;
        public CustomerRecordService(ClientesContext context)
        {
            _context = context;
        }
        public async Task<List<CustomersRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.CustomersRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Customers)
                .Include(x => x.Customers.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public async Task<List<IGrouping<Department, CustomersRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.CustomersRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Customers)
                .Include(x => x.Customers.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Customers.Department)
                .ToListAsync();
        }
    }
}
