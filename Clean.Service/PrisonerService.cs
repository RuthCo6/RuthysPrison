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
    public class PrisonerService : IPrisonerService
    {
        private readonly IPrisonerRepository _PrisonerRepository;
        public PrisonerService(IPrisonerRepository PrisonerRepository)
        {
            _PrisonerRepository = PrisonerRepository;
        }

        public async Task<Prisoner> AddAsync(Prisoner prisoner)
        {
            return await _PrisonerRepository.AddAsync(prisoner);
        }

        public Prisoner GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IPrisonerService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Prisoner>> GetAllAsync()
        {
            return await _PrisonerRepository.GetAllAsync();
        }
        void IPrisonerService.Update(Prisoner prisoner)
        {
            throw new NotImplementedException();
        }

        public List<Prisoner> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
