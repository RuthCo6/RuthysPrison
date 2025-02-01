using AutoMapper;
using clean.API.Models;
using Clean.Core.DTOs;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Prison_GuardController : Controller
    {
        private readonly IPrison_GuardService _prison_GuardService;
        private readonly IMapper _mapper;
        private readonly Manager _manager;

        public Prison_GuardController(Prison_GuardService prison_GuardService, IMapper mapper, Manager manager)
        {
            _prison_GuardService = prison_GuardService;
            _mapper = mapper;
            _manager = manager;
        }
        // GET: Prison_GuardController
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //var calculateTask = Task.Run(() => _manager.Calculate(6, 5));
            var getAllTask = _prison_GuardService.GetAllAsync();

            var list = await _prison_GuardService.GetAllAsync();
            var listDTO = _mapper.Map<IEnumerable<Prison_GuardDTO>>(list);

            //await Task.WhenAll(calculateTask, getAllTask);
            return Ok(getAllTask.Result);
        }

        // GET: Prison_GuardController/Details/5
        [HttpGet("{id}")]

        public ActionResult Get(int id)
        {
            var guard = _prison_GuardService.GetById(id);
            var guardDTO = _mapper.Map<Prison_GuardDTO>(guard);
            return Ok(guardDTO);
        }

        // GET: Prison_GuardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prison_GuardController/Create
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Prison_GuardPostModel guard)
        {
            if (guard == null)
            {
                return BadRequest("Guard data is null."); // החזר 400 אם הנתונים ריקים
            }
            var guardToAdd = new Prison_Guard
            {
                Name = guard.Name,
                Professional_Level = guard.Professional_Level,
                PrisonToFloor = guard.PrisonToFloor
            };
            var newGuard = await _prison_GuardService.AddAsync(guardToAdd);
            return CreatedAtAction(nameof(Get), new { id = newGuard.Id }, newGuard); // החזר 201 עם מיקום חדש
        }

        // GET: Prison_GuardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prison_GuardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prison_GuardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prison_GuardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

