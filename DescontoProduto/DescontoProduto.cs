using System;

namespace DescontoProduto
{
    public class DescontoProduto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public DescontoProduto() // Construtor sem parâmetros
        {
            // Leitura do nome do produto
            Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();

            // Leitura do preço do produto
            Console.WriteLine("Digite o preço do produto: ");
            preco = LerValorDouble();

            // Leitura da quantidade do produto
            Console.WriteLine("Digite a quantidade do produto: ");
            quantidade = LerValorInteiro();
        }

        public DescontoProduto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double CalcularValorTotalSemDesconto()
        {
            return quantidade * preco;
        }

        public double CalcularDesconto()
        {
            if (quantidade >= 11 && quantidade <= 20)
            {
                return 0.1;
            }
            else if (quantidade >= 21 && quantidade <= 50)
            {
                return 0.2;
            }
            else if (quantidade > 50)
            {
                return 0.25;
            }
            else
            {
                return 0;
            }
        }

        public double CalcularValorTotalComDesconto()
        {
            double valorTotalSemDesconto = CalcularValorTotalSemDesconto();
            double desconto = CalcularDesconto();
            return valorTotalSemDesconto - (valorTotalSemDesconto * desconto);
        }

        public string ObterNome()
        {
            return nome;
        }

        public double ObterPreco()
        {
            return preco;
        }

        public int ObterQuantidade()
        {
            return quantidade;
        }

        // Função para ler um valor double do console
        static double LerValorDouble()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido. Digite novamente: ");
            }
            return valor;
        }

        // Função para ler um valor inteiro do console
        static int LerValorInteiro()
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
