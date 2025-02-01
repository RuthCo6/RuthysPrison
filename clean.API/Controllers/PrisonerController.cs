using clean.API.Models;
using Clean.Core.Models;
using Clean.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Clean.Service;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using Clean.Core.DTOs;

namespace clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrisonerController : ControllerBase
    {
        private readonly IPrisonerService _prisonerService;
        private readonly IMapper _mapper;
        private readonly Manager _manager;

        public PrisonerController(IPrisonerService prisonerService, IMapper mapper, Manager manager)
        {
            _prisonerService = prisonerService;
            _mapper = mapper;
            _manager = manager;
        }

        // GET: api/Prisoner
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //var calculateTask = Task.Run(() => _manager.Calculate(6, 5));
            var getAllTask = _prisonerService.GetAllAsync();

            //var list = await _prisonerService.GetAllAsync();
            //var listDTO = _mapper.Map<IEnumerable<PrisonerDTO>>(list);

            //await Task.WhenAll(calculateTask, getAllTask);
            return Ok(getAllTask.Result);
        }

        // GET: api/Prisoner/{id}
        [HttpGet("{id}")]

        public ActionResult Get(int id)
        {
            var prisoner = _prisonerService.GetById(id);
            var prisonerDTO = _mapper.Map<PrisonerDTO>(prisoner);
            return Ok(prisonerDTO);
        }

        // POST: api/Prisoner
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PrisonerPostModel prisoner)
        {
            var prisonerToAdd = new Prisoner
            {
                FamilyName = prisoner.FamilyName,
                Meals = prisoner.Meals,
                YearsInPrison = prisoner.YearsInPrison,
                Level1_10 = prisoner.Level1_10
            };
            var newRoom = await _prisonerService.AddAsync(prisonerToAdd);
            return Ok(newRoom);
        }

        public ActionResult<Prisoner> GetPrisonerById(int id)
        {
            var prisoner = _prisonerService.GetById(id);
            if (prisoner == null)
            {
                return NotFound($"Prisoner with ID {id} not found.");
            }

            return Ok(new Prisoner
            {
                FamilyName = prisoner.FamilyName,
                Level1_10 = prisoner.Level1_10,
                YearsInPrison = prisoner.YearsInPrison,
                Meals = prisoner.Meals
            });
        }


        // PUT: api/Prisoner/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePrisoner(int id, [FromBody] PrisonerPostModel updatedPrisoner)
        {
            var prisoner = _prisonerService.GetById(id);
            if (prisoner == null)
            {
                return NotFound($"Prisoner with ID {id} not found.");
            }

            prisoner.FamilyName = updatedPrisoner.FamilyName;
            prisoner.Level1_10 = updatedPrisoner.Level1_10;
            prisoner.YearsInPrison = updatedPrisoner.YearsInPrison;
            prisoner.Meals = updatedPrisoner.Meals;

            _prisonerService.Update(prisoner);
            return NoContent();
        }

        // DELETE: api/Prisoner/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePrisoner(int id)
        {
            var prisoner = _prisonerService.GetById(id);
            if (prisoner == null)
            {
                return NotFound($"Prisoner with ID {id} not found.");
            }

            _prisonerService.Delete(id);
            return NoContent();
        }
    }
}
