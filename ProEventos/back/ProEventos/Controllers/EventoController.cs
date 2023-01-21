using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Data;
using ProEventos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Evento> Get()
        {

            return _context.Eventos.ToList();
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            var buscaEvento = _context.Eventos.Where(x => x.EventoId == id).FirstOrDefault();
            return buscaEvento;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Evento evento)
        {
            return null;
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo put - {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo put - {id}";
        }
    }
}
