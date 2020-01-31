using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaWebMic.Conexion;
using SistemaWebMic.Logica;
using SistemaWebMic.Models.Entidades;
using SistemaWebMic.ViewModels;

namespace SistemaWebMic.Controllers
{
    public class MiembrosController : Controller
    {
        private readonly IRepositoryGeneral _context;
        private readonly IMapper _mapper;

        public MiembrosController(IRepositoryGeneral context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Miembros
        public async Task<IActionResult> Index()
        {
            var personas = await _context.GetAll<Persona>();
            var personasReturn = _mapper.Map<IEnumerable<PersonaViewModels>>(personas);
            return View(personasReturn);
        }

        // GET: Miembros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.GetById<Persona>(id);
            var personaViewModels = _mapper.Map<PersonaViewModels>(persona);
            if (persona == null)
            {
                return NotFound();
            }

            return View(personaViewModels);
        }

        // GET: Miembros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Miembros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonaViewModels registerViewModels)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Persona registro = new Persona();
                    registro = _mapper.Map<Persona>(registerViewModels);
                    var espiritual = new Datos_Espirituales();
                    var sociedad = new Datos_Sociedad();

                    espiritual.Cuando_Congrega = registerViewModels.Espiritual.Cuando_Congrega;
                    espiritual.FechaBautismo = registerViewModels.Espiritual.FechaBautismo;
                    espiritual.Acepto_Jesus = registerViewModels.Espiritual.Acepto_Jesus;
                    espiritual.Anio = registerViewModels.Espiritual.Anio;
                    espiritual.Bautizado = registerViewModels.Espiritual.Bautizado;
                    espiritual.Invitacion_Iglesia = registerViewModels.Espiritual.Invitacion_Iglesia;
                    espiritual.Llegada_Iglesia = registerViewModels.Espiritual.Llegada_Iglesia;
                    espiritual.LugarBautismo = registerViewModels.Espiritual.LugarBautismo;
                    espiritual.Razones_Mic = registerViewModels.Espiritual.Razones_Mic;
                    espiritual.RecibirConsejeria = registerViewModels.Espiritual.RecibirConsejeria;
                    espiritual.VisitaPrimera = registerViewModels.Espiritual.VisitaPrimera;

                    registro.Espiritual = espiritual;

                    sociedad.LugarTrabajo = registerViewModels.Sociedad.LugarTrabajo;
                    sociedad.NivelEducacion = registerViewModels.Sociedad.NivelEducacion;
                    sociedad.Profesion = registerViewModels.Sociedad.Profesion;
                    registro.Sociedad = sociedad;

                    await _context.Add(registro);
                    return RedirectToAction(nameof(Index));
                }
                return View(registerViewModels); 
            }
            catch (System.Exception ex)
            {
                var mensaje = ex.Message;
                return NotFound();
            }
            
        }

        // GET: Miembros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var persona = await _context.GetById<Persona>(id);
            var espiritual =await _context.First<Datos_Espirituales>(z=>z.PersonaId==persona.Id);
            var sociedad = await _context.First<Datos_Sociedad>(z => z.PersonaId == persona.Id);
            var personaViewModels = _mapper.Map<PersonaViewModels>(persona);
            personaViewModels.Sociedad = _mapper.Map<Datos_SociedadViewModels>(sociedad);
            personaViewModels.Espiritual=_mapper.Map<Datos_EspiritualesViewModels>(espiritual);
            if (persona == null)
            {
                return NotFound();
            }
            return View(personaViewModels);
        }

        // POST: Miembros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RegisterViewModels registerViewModels)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var persona = _mapper.Map<Persona>(registerViewModels);
                    await _context.Update(persona, persona.Id);

                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(registerViewModels);
        }

        // GET: Miembros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.GetById<Persona>(id);
            var personaViewModels = _mapper.Map<MiembrosViewModels>(persona);
            if (persona == null)
            {
                return NotFound();
            }

            return View(personaViewModels);
        }

        // POST: Miembros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.GetById<Persona>(id);
            await _context.Remove(persona);
            return RedirectToAction(nameof(Index));
        }
    }
}
