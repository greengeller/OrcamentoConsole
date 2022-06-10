using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentoConsumer
{

    public class OrcamentoResponse
    {
        public int Id { get; set; }
        public Vendedor Vendedor { get; set; }
        public Produtos Produtos { get; set; }
        public int Quantidade { get; set; }

        private double ComissaoVendedor { get; set; }

        public double ValorTotal { get; set; }
    }


    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}