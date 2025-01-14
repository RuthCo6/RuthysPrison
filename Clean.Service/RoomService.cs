using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
//using Clean.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _UserRepository;
        public RoomService(IRoomRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        //public Room Add(Room room)
        //{
        //    return _UserRepository.Add(room);
        //}

        public Room Add()
        {
            throw new NotImplementedException();
        }

        //public void Delete(int id)
        //{
        //    _UserRepository.Delete(id);
        //}

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> GetAll()
        {
            return _UserRepository.GetList();
        }
    }
}
