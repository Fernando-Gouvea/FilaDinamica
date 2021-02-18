using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02fila
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu = 0, cont = 0;
            FilaOS minhaFila = new FilaOS
            {
                Head = null,
                Tail = null
            };

            OrdemServico order = new OrdemServico();

            do
            {
                Console.Clear();
                Console.WriteLine("<==Serviços Gerais==> ");
                Console.WriteLine("1-) Inserir Ordem de Serviço: ");
                Console.WriteLine("2-) Remover Ordem de Serviço: ");
                Console.WriteLine("3-) Imprimir Ordem: ");
                Console.WriteLine("4-) Quantidade de elementos na fila: ");
                Console.WriteLine("5-) Busca de ordem por numero: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        InserirOrdem(order, minhaFila, ref cont);
                        Console.ReadKey();
                        break;

                    case 2:
                       
                      
                        Console.WriteLine(removerOrdem(minhaFila, ref cont));
                        Console.ReadKey();
                        break;

                    case 3:
                        minhaFila.Print();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("A pilha tem " + cont + " elementos");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Digite o numero da ordem a ser encontrado: ");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine(minhaFila.ProcuraNota(numero));
                        Console.ReadKey();

                        break;
                }
            }
            while (true);

        }


        static void InserirOrdem(OrdemServico order, FilaOS f, ref int cont)
        {
            Console.WriteLine("Numero da ordem: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTipo da ordem: ");
            String tipo = Console.ReadLine();
            Console.WriteLine("Descrição do trabalho: ");
            String descricao = Console.ReadLine();
            Console.WriteLine("Prazo em dias: ");
            int prazo = int.Parse(Console.ReadLine());


            order = new OrdemServico
            {
                Numero = numero,
                Tipo = tipo,
                Descricao = descricao,
                DataCriacao = DateTime.Now,
                Prazo = prazo


            };
            f.Push(order);
            cont++;
        }

        static string removerOrdem(FilaOS f, ref int cont)
        {
               cont--;
               f.Pop();

            return "Operação realizada\n";
        }






    }
}


