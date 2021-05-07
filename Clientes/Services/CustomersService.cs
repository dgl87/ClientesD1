using Clientes.Data;
using Clientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clientes.Services.Exception;

namespace Clientes.Service
{
    public class CustomersService
    {
        private readonly ClientesContext _context;

        public CustomersService(ClientesContext context)
        {
            _context = context;
        }
        public async Task<List<Customers>> FindAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }
        public async Task InsertAsync(Customers obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Customers> FindByIdAsync(int id)
        {
            return await _context.Customers.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Customers.FindAsync(id);
                _context.Customers.Remove(obj);
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task UpdateAsync(Customers obj)
        {
            bool hasAny = await _context.Customers.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
