using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace loja2
{
    public class Produto
    {
        public string Nome;
        public double Preço;
        public int Quantidade;
        public int QuantidadeASerAdicionada;
        public int QuantidadeASerRetirada;

        public double ValorTotalEmEstoque()
        {
            return Preço * Quantidade;
        }

        public override string ToString()
        {
            return 
            "Produto: " 
            + Nome + "\n$" 
            + Preço.ToString("F2", CultureInfo.InvariantCulture) + "\n" 
            + Quantidade 
            + " unidades\n" 
            + "Total: $" 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }
    }
}