using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAsNoTrack
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }

        public Contato(string nome, string numero)
        {
            this.Nome = nome;
            this.Numero = numero;
        }
    }
}
