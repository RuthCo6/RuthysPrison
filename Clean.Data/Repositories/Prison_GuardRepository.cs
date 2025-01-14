using Clean.Core;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
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

        public List<Prison_Guard> GetList()
        {
            return _context.guards.ToList();
        }
    }
}
