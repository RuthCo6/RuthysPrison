using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.DTOs
{
    public class Prison_GuardDTO
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Professional_Level { get; set; }
        public int PrisonToFloor { get; set; }
    }
}
