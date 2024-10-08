using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContato
{
    public class Telefone
    {
        public string Tipo { get; set; }      // Exemplo: "celular", "residencial"
        public string Numero { get; set; }    // Exemplo: "(11) 99999-9999"
        public bool Principal { get; set; }   // Indica se é o telefone principal

        public override string ToString()
        {
            return $"{Tipo}: {Numero} (Principal: {Principal})";
        }
    }
}
