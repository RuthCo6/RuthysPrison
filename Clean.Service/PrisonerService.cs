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


        public List<Prisoner> GetAll()
        {
            return _PrisonerRepository.GetList();
        }

    }
}
