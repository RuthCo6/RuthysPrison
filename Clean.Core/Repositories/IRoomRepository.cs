using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IRoomRepository
    {
        void Delete(int id);

        Task<Room> AddAsync(Room room);
        //void Delete(int id);
        Task<IEnumerable<Room>> GetAllAsync();
        Room GetById(int id);
        //IEnumerable<Room> GetList(int id);
        //IEnumerable<Room> GetList();
        List<Room> GetList();
        //Room Update(int id, Room room);
    }
}
