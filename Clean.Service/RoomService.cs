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

        public async Task<Room> AddAsync(Room room)
        {
            return await _UserRepository.AddAsync(room);
        }

        public Room Add()
        {
            throw new NotImplementedException();
        }

        public Room Add(Room roomToAdd)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _UserRepository.Delete(id);
        }

        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            return await _UserRepository.GetAllAsync();
        }

        public Room GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
