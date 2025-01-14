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
        List<Prison_Guard> GetAll();
    }
}
