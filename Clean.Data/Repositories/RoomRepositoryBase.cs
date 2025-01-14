using Clean.Core.Models;

namespace Clean.Data.Repositories
{
    public class RoomRepositoryBase
    {
        private readonly DataContext _context;
        public Room Add(Room room)
        {
            _context.rooms.Add(room);
            _context.SaveChanges();
            return room;
        }
        //public Room Delete(int id)
        //{
        //    var room = GetById(id);
        //    _context.rooms.Remove(room);
        //    _context.SaveChanges();
        //}

        public Room GetById(int id)
        {
            return _context.rooms.Find(id);
        }

        public IEnumerable<Room> GetList(int id)
        {
            return _context.rooms.Where(r => !string.IsNullOrEmpty(r.Well_groomed));
        }
        public Room Update(int id, Room room)
        {
            var existRoom = GetById(id);
            existRoom.Id = room.Id;
            existRoom.Tiny_Neglected = room.Tiny_Neglected;
            _context.SaveChanges();
            return existRoom;
        }
    }
}