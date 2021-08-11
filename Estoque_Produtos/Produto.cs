using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque_Produtos
{
    class Produto
    {

        public string Nome;
        public int Quantidade;
        public double Preco;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

    }
}
