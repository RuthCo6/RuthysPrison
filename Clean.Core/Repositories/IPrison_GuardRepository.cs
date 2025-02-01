using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IPrison_GuardRepository
    {
        List<Prison_Guard> GetList();
        Task<Prison_Guard> AddAsync(Prison_Guard guard);
        Task<IEnumerable<Prison_Guard>> GetAllAsync();
        Prison_Guard GetById(int id);

    }
}
