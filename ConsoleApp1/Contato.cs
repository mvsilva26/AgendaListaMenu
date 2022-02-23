using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Contato Proximo { get; set; }
        public Lista_Telefones Telefones { get; set; }


        public Contato(string nome, string email, Lista_Telefones telefones)
        {
            Nome = nome;
            Email = email;         
            Telefones = telefones;
            Proximo = null;

        }

        
        
        public override string ToString()
        {
            return "\n" + "Nome: " + Nome + "\n" + "Email: " + Email + "\n";
        }
        
    }
}
