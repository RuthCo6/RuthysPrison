using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data
{
    public interface IDataContext
    {
        public List<Room> rooms { get; set; }
    }
}
