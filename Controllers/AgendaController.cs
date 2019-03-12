using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_agenda.Models;
using Newtonsoft.Json;

namespace api_agenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {   
        private readonly ContatoService _service;
        public AgendaController(ContatoService _Service)
        {
            _service = _Service;
        }
        // GET api/agenda
        [HttpGet]
        public string Get()
        {
            var contatos = _service.pegarTudo();            
            return contatos;
        }

        // GET api/agenda/5
        [HttpGet]
        [Route("Name")]        
        public string Name(int id)
        {
            var contatoNome = _service.pegarNomePorId(id);
            return contatoNome + " 'Teste' " + id;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
