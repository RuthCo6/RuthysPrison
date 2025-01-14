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
        //Room Add(Room room);
        //void Delete(int id);
        //Room GetById(int id);
        //IEnumerable<Room> GetList(int id);
        //IEnumerable<Room> GetList();
        List<Room> GetList();
        //Room Update(int id, Room room);
    }
}
