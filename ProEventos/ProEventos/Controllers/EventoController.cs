using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public IEnumerable<Evento> _eventos = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "BH",
                Lote = "1 LOTE",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImageURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular 11 e .Net 5 e suas novidades",
                Local = "SP",
                Lote = "1 LOTE",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageURL = "foto1.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {

            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            var buscaEvento = _eventos.Where(x => x.EventoId == id).ToList();
            return buscaEvento;
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
