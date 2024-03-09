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
            double precoProduto = LerDouble();

            // Leitura da quantidade do produto
            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidadeProduto = LerInt();

            // Cálculo do valor total sem desconto
            double valorTotalSemDesconto = quantidadeProduto * precoProduto;

            // Cálculo do desconto
            double desconto = 0;
            if (quantidadeProduto >= 11 && quantidadeProduto <= 20)
            {
                desconto = 0.1;
            }
            else if (quantidadeProduto >= 21 && quantidadeProduto <= 50)
            {
                desconto = 0.2;
            }
            else if (quantidadeProduto > 50)
            {
                desconto = 0.25;
            }

            // Cálculo do valor total com desconto
            double valorTotalComDesconto = valorTotalSemDesconto - (valorTotalSemDesconto * desconto);

            // Exibição dos resultados
            Console.WriteLine("Nome do produto: {0}", nomeProduto);
            Console.WriteLine("Preço do produto: R${0}", precoProduto.ToString("F2"));
            Console.WriteLine("Quantidade do produto: {0}", quantidadeProduto);
            Console.WriteLine("Valor total sem desconto: R${0}", valorTotalSemDesconto.ToString("F2"));
            Console.WriteLine("Desconto: {0}%", (desconto * 100).ToString("F2"));
            Console.WriteLine("Valor total com desconto: R${0}", valorTotalComDesconto.ToString("F2"));
        }

        // Função para ler um valor double do console
        static double LerDouble()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido. Digite novamente: ");
            }
            return valor;
        }

        // Função para ler um valor int do console
        static int LerInt()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido. Digite novamente: ");
            }
            return valor;
        }
    }
}
