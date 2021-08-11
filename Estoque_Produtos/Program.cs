using System;
using System.Globalization;

namespace Estoque_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Prod;
            Prod = new Produto();

            Console.WriteLine(" Ente com os dados do produto: ");
            Console.WriteLine(" Nome: ");
            Prod.Nome = Console.ReadLine();
            
            Console.WriteLine(" Preço: ");
            Prod.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine(" Quantidade no estoque: ");
            Prod.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Dados do produto: " + Prod.Nome + ", $ " + Prod.Preco + ", " + Prod.Quantidade + " unidades, Total: $ " );

            Console.WriteLine(" Digite o Número de produtos a ser adicionado: ");
            Prod.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
    }
}
