using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Services
{
    public interface IRoomService
    {
        Task<Room> AddAsync(Room roomToAdd);
        //void Delete();
        Task<IEnumerable<Room>> GetAllAsync();
        Room GetById(int id);
    }
}
