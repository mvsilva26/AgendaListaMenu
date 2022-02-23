using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static Contato InserirContato()
        {
            Lista_Telefones telefone = new Lista_Telefones();

            Console.WriteLine(" -- Cadastro de Contato -- ");
            string nome;
            string email;
            string tipo;
            int ddd;
            int numero;
           // int limite = 0;

            Console.WriteLine("Digite o Nome: ");
            nome = Console.ReadLine();
            nome = nome.ToUpper();

            Console.WriteLine("Digite o Email: ");
            email = Console.ReadLine();

            int op = 1;
            do
            {              
                    Console.WriteLine("Digite o Tipo: - Celular - Casa - Trabalho");
                    tipo = Console.ReadLine().ToUpper();
                    Console.WriteLine("Digite o DDD: ");
                    ddd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o Número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    telefone.push(new Telefones(tipo, ddd, numero));

                    Console.WriteLine(" -- Adicionar um novo telefone -- ");
                    Console.WriteLine(" 1 - Para adicionar novo contato e qualquer tecla para sair");
                    op = Convert.ToInt32((Console.ReadLine()));
                                 
            } while (op == 1);


            return new Contato(nome, email, telefone);
        }

        



        static void Main(string[] args)
        {
            Lista_Contato c = new Lista_Contato();

            string Remover()
            {

                Console.WriteLine(" -- REMOVER POR NOME -- ");
                Console.WriteLine("Digite o nome do contato que deseja remover: ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();
                return nome;

            }

            int opc = 0;

            while (opc != 6)
            {
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("1 - Inserir Contato ");
                Console.WriteLine("2 - Localizar Contato ");
                Console.WriteLine("3 - Remover Contato ");
                Console.WriteLine("4 - Editar Contato ");
                Console.WriteLine("5 - Imprimir Contato ");
                Console.WriteLine("6 - Sair ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        c.push(InserirContato());
                        break;
                    case 2:
                        Console.Clear();
                        c.pesquisar();
                        break;
                    case 3:
                        Console.Clear();
                        c.pop(Remover());
                        break;
                    case 4:
                        Console.Clear();
                        c.editar();
                        break;
                    case 5:
                        Console.Clear();
                        c.print();
                        break;
                    default:
                        break;
                }
            }



        }
    }
}
