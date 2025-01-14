using Clean.Core;
using Clean.Core.Models;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;
        public RoomRepository(DataContext context)
        {
            _context = context;
        }
        public List<Room> GetList()
        {
            return _context.rooms.ToList();
        }
        //public Room Add(Room room)
        //{
        //    _context.rooms.Add(room);
        //    _context.SaveChanges();
        //    return room;
        //}

        //public void Delete(int id)
        //{
        //    var room = GetById(id);
        //    _context.rooms.Remove(room);
        //    _context.SaveChanges();
        //}

        //public Room GetById(int id)
        //{
        //    return _context.rooms.Find(id);
        //}
        //public IEnumerable<Room> GetList(int id)
        //{
        //    return _context.rooms.Where(r => !string.IsNullOrEmpty(r.Well_groomed));
        //}

        //public Room Update(int id, Room room)
        //{
        //    var existRoom = GetById(id);
        //    existRoom.Id = room.Id;
        //    existRoom.Tiny_Neglected = room.Tiny_Neglected;
        //    _context.SaveChanges();
        //    return existRoom;
        //}
    }
}
