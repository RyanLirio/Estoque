using System;
using System.Globalization;

namespace loja2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.Clear();

            Console.WriteLine("Qual produto deseja cadastrar no estoque?");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Qual o preço desse produto?");
            p.Preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a quantidade desse produto em estoque?");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(p);

            Console.WriteLine("Deseja adicionar ou retirar unidades do estoque?\n1 - Adicionar\n2 - Retirar");
            int estoque = int.Parse(Console.ReadLine());
            
            if (estoque == 1)
            {
                Console.WriteLine("\nDeseja adicionar quantas unidades ao estoque?");
                p.QuantidadeASerAdicionada = int.Parse(Console.ReadLine());
                p.Quantidade += p.QuantidadeASerAdicionada;   
            }
            else if(estoque == 2)
            {
                Console.WriteLine("\nDeseja retirar quantas unidades ao estoque?");
                p.QuantidadeASerRetirada = int.Parse(Console.ReadLine()); 
                p.Quantidade -= p.QuantidadeASerRetirada;  
            }
            Console.WriteLine(p);

        }
    }
}