using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Services
{
    public interface IPrison_GuardService
    {
        //List<Prison_Guard> GetAll();
        Task<Prison_Guard> AddAsync(Prison_Guard guardToAdd);
        Task<IEnumerable<Prison_Guard>> GetAllAsync();
        Prison_Guard GetById(int id);
    }
}
