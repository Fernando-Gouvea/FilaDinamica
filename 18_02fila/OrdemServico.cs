using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02fila
{
    class OrdemServico
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Prazo { get; set; }
        public OrdemServico Proximo { get; set; }

        public override string ToString()
        {
            return "\nNumero: " + Numero +
                   "\nTipo: " + Tipo +
                   "\nDescrição: " + Descricao +
                   "\nData de criação da order: " + DataCriacao +
                   "\nPrazo: " + Prazo;

        }


    }
}
