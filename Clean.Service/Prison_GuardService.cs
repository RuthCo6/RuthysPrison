using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class Prison_GuardService : IPrison_GuardService
    {
        private readonly IPrison_GuardRepository _GuardRepository;
        public Prison_GuardService(IPrison_GuardRepository GuardRepository)
        {
            _GuardRepository = GuardRepository;
        }

        public async Task<Prison_Guard> AddAsync(Prison_Guard guard)
        {
            return await _GuardRepository.AddAsync(guard);
        }

        public List<Prison_Guard> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Prison_Guard>> GetAllAsync()
        {
            return await _GuardRepository.GetAllAsync();
        }

        public Prison_Guard GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
