using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Linq;

namespace api_agenda.Models
{
    public class ContatoService
    {
        private readonly AgendaContext _Context;
        public ContatoService(AgendaContext _context)
        {
            _Context = _context;
        }

        public string pegarTudo(){
            var retorno = _Context.Contato;
            return JsonConvert.SerializeObject(retorno);;
        }
    }
}