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


        public List<Prison_Guard> GetAll()
        {
            return _GuardRepository.GetList();
        }
    }
}
