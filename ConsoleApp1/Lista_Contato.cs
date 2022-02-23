using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lista_Contato
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }

        public Lista_Contato()
        {
            Head = null;
            Tail = null;
        }

        
        public void push(Contato aux)
        {
            if (Head == null || Tail == null)
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                if (Head == Tail)
                {
                    //Quando um objeto entra pelo TAIL
                    if (aux.Nome.CompareTo(Head.Nome) == 1 || aux.Nome.CompareTo(Head.Nome) == 0)
                    {
                        Tail.Proximo = aux;
                        Tail = aux;
                    }
                    // Quando um objeto entra pelo HEAD
                    else if (aux.Nome.CompareTo(Head.Nome) == -1)
                    {
                        aux.Proximo = Head;
                        Head = aux;
                    }
                }
                else
                {
                    Contato aux1 = Head;
                    Contato aux2 = Head;
                    do
                    {
                        //Inicio
                        if (aux.Nome.CompareTo(aux1.Nome) == -1 && aux.Nome.CompareTo(aux2.Nome) == -1)
                        {
                            aux.Proximo = Head;
                            Head = aux;
                            aux1 = null;
                        } //Adiciona numero igual ordenado
                        else if (aux.Nome.CompareTo(aux1.Nome) == 0)
                        {
                            //mover
                            aux2 = aux1;
                            aux1 = aux1.Proximo;
                            // encadear
                            aux2.Proximo = aux;
                            aux.Proximo = aux1;
                            aux1 = null;
                        }
                        //Adiciona no meio
                        else if (aux.Nome.CompareTo(aux2.Nome) == 1 && aux.Nome.CompareTo(aux1.Nome) == -1)
                        {
                            aux2.Proximo = aux;
                            aux.Proximo = aux1;
                            aux1 = null;
                        }
                        //Final
                        else if (aux1 == Tail && (aux.Nome.CompareTo(aux1.Nome) == 1 || aux.Nome.CompareTo(aux1.Nome) == 0))
                        {
                            Tail.Proximo = aux;
                            Tail = aux;
                            aux1 = null;
                        }// continua
                        else if (aux.Nome.CompareTo(aux1.Nome) == 1 && aux.Nome.CompareTo(aux2.Nome) == 1)
                        {
                            aux2 = aux1;
                            aux1 = aux1.Proximo;
                        }
                    } while (aux1 != null);
                }
            }
            Console.WriteLine("\n -- CONTATO CADASTRADO COM SUCESSO -- \n");
        }
        public bool vazia()
        {
            if (Head == null && Tail == null)
                return true;
            else
                return false;
        }
        public void print()
        {
            if (vazia())
            {
                Console.WriteLine("\n -- AGENDA VAZIA -- \n");
            }
            else
            {
                if (Head != null)
                {
                    Contato aux = Head;
                    do
                    {
                        Console.WriteLine(aux.ToString());
                        Telefones telefone = aux.Telefones.Head;
                        do
                        {
                            Console.WriteLine(telefone.ToString());
                            telefone = telefone.Proximo;
                        } while (telefone != null);                    
                        aux = aux.Proximo;
                        Console.ReadKey();
                    } while (aux != null);
                }
                else
                {
                    Console.WriteLine(" -- AGENDA VAZIO -- \n");
                }
            }
        }
        public void pesquisar()
        {
            if (vazia())
            {   
                Console.WriteLine("\n -- AGENDA VAZIA -- \n");
            }
            else
            {
                Console.Write("\n -- PESQUISAR POR NOME -- ");
                Console.Write("\n Digite o nome do contato: ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();
                bool erro = true;
                Contato aux = Head;
                do
                {
                    if (aux.Nome == nome)
                    {
                        Console.WriteLine(aux.ToString());
                        Telefones telefone = aux.Telefones.Head;
                        do
                        {
                            Console.WriteLine(telefone.ToString());
                            telefone = telefone.Proximo;
                        } while (telefone != null);
                        erro = false;
                    }
                    aux = aux.Proximo;
                } while (aux != null);
                if (erro == true)
                    Console.WriteLine("\n -- CONTATO NÃO EXISTE -- n");
            }
        }
        public void pop(string nome)
        {
            if (vazia())
            {
                Console.WriteLine("\n -- AGENDA VAZIA -- n");
            }
            else
            {
                bool erro = true;
                Contato aux1 = Head;
                Contato aux2 = Head;
                do
                {
                    if (aux1.Nome == nome)
                    {
                        if (Head == Tail)
                        {
                            Head = Tail = null;
                        }
                        else if (aux1 == Head)
                        {
                            Head = aux1.Proximo;
                        }
                        else if (aux1 == Head)
                        {
                            aux2.Proximo = Tail;
                            Tail = aux2;
                            Tail.Proximo = null;
                        }
                        else if (aux2.Nome.CompareTo(nome) == -1)
                        {
                            aux2.Proximo = aux1.Proximo;
                            aux2 = aux1.Proximo;
                        }
                        aux1 = null;
                        erro = false;
                    }
                    else
                    {
                        aux2 = aux1;
                        aux1 = aux1.Proximo;
                    }
                } while (aux1 != null);
                if (erro == true)
                    Console.WriteLine("\n -- CONTATO NÃO EXISTE -- n");
            }
        }

        public void editar()
        {
            if (vazia())
            {
                Console.WriteLine("\n -- AGENDA VAZIA -- n");
            }
            else
            {
                Console.WriteLine("\n -- EDITAR CONTATO -- ");
                Console.Write("\nDigite o nome que deseja editar: ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();
                bool erro = true;
                Contato aux = Head;
                do
                {
                    if (aux.Nome == nome)
                    {
                        Console.WriteLine(aux.ToString());
                        Telefones aux_telefone = aux.Telefones.Head;
                        do
                        {
                            Console.WriteLine(aux_telefone.ToString());
                            aux_telefone = aux_telefone.Proximo;
                        } while (aux_telefone != null);
                        Console.WriteLine(" -- O QUE DESEJA EDITAR? -- ");
                        Console.WriteLine(" 1 - Para nome");
                        Console.WriteLine(" 2 - Para email");
                        Console.WriteLine(" 3 - Para Telefone ");
                        string opcao = Console.ReadLine();
                        switch (opcao)
                        {
                            case "1":
                                Console.Write("Digite o novo nome: ");
                                nome = Console.ReadLine();
                                nome = nome.ToUpper();
                                push(new Contato(nome, aux.Email, aux.Telefones));
                                pop(aux.Nome);
                                break;
                            case "2":
                                Console.Write("Digite o novo email: ");
                                aux.Email = Console.ReadLine();
                                break;
                            case "3":
                                Console.WriteLine("\n -- EDITAR CONTATO -- ");
                                Console.Write("\nDigite o Tipo que deseja editar: ");
                                string tipo = Console.ReadLine();
                                tipo = tipo.ToUpper();
                                Console.WriteLine(aux.ToString());
                                aux_telefone = aux.Telefones.Head;
                                do
                                {
                                    if (aux_telefone.Tipo == tipo)
                                    {
                                        Console.WriteLine(" -- Digite o quer editar no(a) " + tipo + " -- ");
                                        Console.WriteLine(" 1 - Para Tipo");
                                        Console.WriteLine(" 2 - Para DDD");
                                        Console.WriteLine(" 3 - Para Numero ");
                                        string op = Console.ReadLine();
                                        switch (op)
                                        {
                                            case "1":
                                                Console.Write("Digite o novo Tipo: ");
                                                aux_telefone.Tipo = Console.ReadLine().ToUpper();
                                                break;
                                            case "2":
                                                Console.Write("Digite o novo DDD: ");
                                                aux_telefone.DDD = int.Parse(Console.ReadLine());
                                                break;
                                            case "3":
                                                Console.Write("Digite o novo Numero: ");
                                                aux_telefone.Numero = int.Parse(Console.ReadLine());
                                                break;
                                            default:
                                                Console.WriteLine("~-- OPÇÃO INVÁLIDA -- ");
                                                break;
                                        }
                                    }
                                    aux_telefone = aux_telefone.Proximo;
                                } while (aux_telefone != null);
                                break;
                            default:
                                break;
                        }
                        erro = false;
                    }
                    aux = aux.Proximo;
                } while (aux != null);
                if (erro == true)
                    Console.WriteLine("\n -- CONTATO NÃO EXISTE -- \n");
            }
        }

    }

}

