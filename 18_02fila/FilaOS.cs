using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02fila
{
    class FilaOS
    {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }

        public bool Vazia()
        {
            if ((Head == null) && (Tail == null))
            {
                return true;
            }
            return false;
        }

        public void Push(OrdemServico aux)
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
            }

            else
            {
                Tail.Proximo = aux;  // encadeamento ao novo objeto
                Tail = aux;  // aponta para o ultimo elemento
            }
            Console.WriteLine("Elemento inserido com sucesso!!!");

        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel imprimir! fila vazia.");
                Console.ReadKey();
            }
            else
            {
                OrdemServico aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }
                while (aux!=null);
                Console.WriteLine("<<--Fim da fila-->>");
            }


        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel remover...fila vazia!!!");
                Console.ReadKey();
            }
            else
            {
                Head = Head.Proximo;
                if (Head == null)
                {
                    Tail = null;
                    Console.WriteLine("Fila esta vazia!!!");
                    Console.ReadKey();
                }
            }


        }

    

        public string ProcuraNota(int procura)
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel localizar! fila vazia.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nProcurando. . .\n");
                OrdemServico aux = Head;
                do
                {
                    if (procura == aux.Numero)
                    {
                        Console.WriteLine("Nota encontrada!!!");
                        return aux.ToString();
                    }

                    aux = aux.Proximo;
                }
                while (aux != null);
                Console.WriteLine("<<--Fim da fila-->>");
            }

            return "Nota não inexistente!!!";

        }




    }
}
