using Clean.Core;
using Clean.Core.Models;
using Clean.Core.Repositories;
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

        public List<Prisoner> GetList()
        {
            return _context.prisoners.ToList();
        }
    }
}
