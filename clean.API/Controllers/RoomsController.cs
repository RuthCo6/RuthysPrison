using Clean.Core.Models;
using Clean.Core.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Roomscontroller : ControllerBase
    {
        private readonly IRoomService _RoomService;

        public Roomscontroller(IRoomService roomService)
        {
            _RoomService = roomService;
        }
        //private readonly UserRepository _userRepository;

        //public UserController(UserRepository userRepository)
        //{
        //    _userRepository = userRepository;
        //}

        // GET: api/<Userscontroller>
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return _RoomService.GetAll();
        }

        // GET api/<Userscontroller>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            foreach (Room room in _RoomService.GetAll())
            {
                if (room.Id == id)
                {
                    return Ok(room);
                }
            }
            return NotFound("id not found:(");
        }

        // POST api/<Userscontroller>
        [HttpPost]
        public void Post(Room r)
        {
            //_RoomService.GetAll().Add(r);
        }

        // PUT api/<Userscontroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<Userscontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
