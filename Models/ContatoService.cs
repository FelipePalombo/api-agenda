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
            var retorno = from contato in _Context.Contato select contato;
            return JsonConvert.SerializeObject(retorno);
        }

        public string pegarNomePorId(int id){
            var idRecebido = id;
            var retorno = _Context.Contato.Where(contato => contato.Id == idRecebido).Select(ct => ct.Nome);
            return JsonConvert.SerializeObject(retorno);
        }
    }
}