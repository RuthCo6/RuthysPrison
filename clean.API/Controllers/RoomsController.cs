using AutoMapper;
using clean.API.Models;
using Clean.Core;
using Clean.Core.DTOs;
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
        private readonly IMapper _mapper;
        private readonly Manager _manager;

        public Roomscontroller(IRoomService roomService, IMapper mapper, Manager manager)
        {
            _RoomService = roomService;
            _mapper = mapper;
            _manager = manager;
        }

        // GET: api/<Roomscontroller>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //var calculateTask = Task.Run(() => _manager.Calculate(6, 5));
            var getAllTask = _RoomService.GetAllAsync();

            var list = await _RoomService.GetAllAsync();
            var listDTO = _mapper.Map<IEnumerable<RoomDTO>>(list);

            //await Task.WhenAll(calculateTask, getAllTask);
            return Ok(getAllTask.Result);
        }

        // GET api/<Userscontroller>/5
        [HttpGet("{id}")]

        public ActionResult Get(int id)
        {
            var room = _RoomService.GetById(id);
            var roomDTO = _mapper.Map<RoomDTO>(room);
            return Ok(roomDTO);
        }

        // POST api/<Userscontroller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RoomPostModel room)
        {
            var roomToAdd = new Room
            {
                Tiny_Neglected = room.Tiny_Neglected,
                Well_groomed = room.Well_groomed
            };
            var newRoom = await _RoomService.AddAsync(roomToAdd);
            return Ok(newRoom);
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
