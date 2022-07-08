using System;
using System.Collections.Generic;
using System.Text;

namespace IQueryable
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }

        public virtual Genero Genero { get; set; }
    }
}
