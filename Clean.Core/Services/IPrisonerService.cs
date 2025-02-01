using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Services
{
    public interface IPrisonerService
    {
        //List<Prisoner> GetAll();
        Task<Prisoner> AddAsync(Prisoner prisoner);
        Task<IEnumerable<Prisoner>> GetAllAsync();
        Prisoner GetById(int id);
        void Update(Prisoner prisoner);
        void Delete(int id);
    }
}
