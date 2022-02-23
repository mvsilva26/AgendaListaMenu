using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Telefones
    {
        public string Tipo { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
        public Telefones Proximo { get; set; }

        public Telefones(string tipo, int dDD, int numero)
        {
            Tipo = tipo;
            DDD = dDD;
            Numero = numero;
            Proximo = null;
        }

        public override string ToString()
        {
            return "Tipo: " + Tipo + "\n" + "(" + DDD + ")" + Numero;
        }
    }
}
