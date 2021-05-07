using Clientes.Data;
using Clientes.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Services
{
    public class DepartmentService
    {
        private readonly ClientesContext _context;
        public DepartmentService(ClientesContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
