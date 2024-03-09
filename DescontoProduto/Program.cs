using System;

namespace DescontoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leitura do nome do produto
            Console.WriteLine("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            // Leitura do preço do produto
            Console.WriteLine("Digite o preço do produto: ");
            double precoProduto = Util.LerValorDouble(); // Use Util.LerValorDouble()

            // Leitura da quantidade do produto
            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidadeProduto = Util.LerValorInteiro(); // Use Util.LerValorInteiro()

            // Criação da instância da classe DescontoProduto
            DescontoProduto descontoProduto = new DescontoProduto(nomeProduto, precoProduto, quantidadeProduto);

            // Exibição dos resultados
            Console.WriteLine("Nome do produto: {0}", descontoProduto.ObterNome());
            Console.WriteLine("Preço do produto: R${0}", descontoProduto.ObterPreco().ToString("F2"));
            Console.WriteLine("Quantidade do produto: {0}", descontoProduto.ObterQuantidade());
            Console.WriteLine("Valor total sem desconto: R${0}", descontoProduto.CalcularValorTotalSemDesconto().ToString("F2"));
            Console.WriteLine("Desconto: {0}%", (descontoProduto.CalcularDesconto() * 100).ToString("F2"));
            Console.WriteLine("Valor total com desconto: R${0}", descontoProduto.CalcularValorTotalComDesconto().ToString("F2"));
        }
    }
}
