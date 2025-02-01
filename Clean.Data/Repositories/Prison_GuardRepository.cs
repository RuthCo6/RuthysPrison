using Clean.Core;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class Prison_GuardRepository : IPrison_GuardRepository
    {
        private readonly DataContext _context;
        public Prison_GuardRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Prison_Guard> AddAsync(Prison_Guard guard)
        {
            _context.guards.Add(guard);
            await _context.SaveChangesAsync();
            return guard;
        }

        public async Task<IEnumerable<Prison_Guard>> GetAllAsync()
        {
            return await _context.guards.Include(r => r.Id).ToListAsync();
        }

        public Prison_Guard GetById(int id)
        {
            return _context.guards.Find(id);
        }

        public List<Prison_Guard> GetList()
        {
            return _context.guards.ToList();
        }
    }
}
