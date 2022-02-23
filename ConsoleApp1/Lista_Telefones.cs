using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lista_Telefones
    {

        public Telefones Head { get; set; }
        public Telefones Tail { get; set; }

        public Lista_Telefones()
        {
            Head = null;
            Tail = null;
        }

        public bool vazia()
        {
            if (Head == null && Tail == null)
                return true;
            else
                return false;
        }

        public void push(Telefones aux)
        {
            if (vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
        }

        public void print()
        {
            if (vazia())
            {
                Console.WriteLine("\n -- AGENDA VAZIA -- \n");
            }
            else
            {
               
                Telefones aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());                   
                    aux = aux.Proximo;
                    Console.ReadKey();
                } while (aux != null);              
                
            }
        }



    }
}
