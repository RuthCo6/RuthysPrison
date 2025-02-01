using Clean.Core;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class PrisonerRepository : IPrisonerRepository
    {
        private readonly DataContext _context;
        public PrisonerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Prisoner> AddAsync(Prisoner prisoner)
        {
            _context.prisoners.Add(prisoner);
            await _context.SaveChangesAsync();
            return prisoner;
        }

        public async Task<IEnumerable<Prisoner>> GetAllAsync()
        {
            return await _context.prisoners.Include(p => p.Id).ToListAsync();
        }
        public Prisoner GetById(int id)
        {
            return _context.prisoners.Find(id);
        }

        public List<Prisoner> GetList()
        {
            return _context.prisoners.ToList();
        }
    }
}
