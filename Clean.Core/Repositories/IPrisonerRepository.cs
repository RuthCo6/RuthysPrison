using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IPrisonerRepository
    {
        List<Prisoner> GetList();
    }
}
