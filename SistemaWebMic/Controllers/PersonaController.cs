using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaWebMic.Logica;
using SistemaWebMic.Models.Entidades;
using SistemaWebMic.ViewModels;

namespace SistemaWebMic.Controllers
{
    public class PersonaController: Controller
    {
        private readonly IRepositoryGeneral _rep;
        private readonly IMapper _mapper;

        public PersonaController(IRepositoryGeneral rep, IMapper mapper)
        {
            _mapper = mapper;
            _rep = rep;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersonas()
        {
            var personas = await _rep.GetAll<Persona>();
            var personasReturn = _mapper.Map<IEnumerable<MiembrosViewModels>>(personas);
            return View("Persona",personasReturn);
        }

        [HttpGet]
        public async Task<IActionResult> GetByPersona(int id)
        {
            var persona = await _rep.GetById<Persona>(id);
            var personaReturn = _mapper.Map<MiembrosViewModels>(persona);
            return View(personaReturn);
        }

        // [HttpGet]
        // public async Task<IActionResult> Register()
        // {
        //     // var personaReturn = _mapper.Map<MiembrosViewModels>(persona);
        //     // return View(personaReturn);
        // }
    }
}