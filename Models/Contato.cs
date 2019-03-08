using System;
using System.Collections.Generic;

namespace api_agenda.Models
{
    public partial class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int? Idade { get; set; }
        public int? Telefone { get; set; }
    }
}
