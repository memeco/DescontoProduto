using System;

namespace DescontoProduto
{
    public class DescontoProduto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public DescontoProduto() // Construtor sem parâmetros
        {
            // Leitura do nome do produto
            Console.WriteLine("Digite o nome do produto: ");
            _nome = Console.ReadLine();

            // Leitura do preço do produto
            Console.WriteLine("Digite o preço do produto: ");
            _preco = LerValorDouble();

            // Leitura da quantidade do produto
            Console.WriteLine("Digite a quantidade do produto: ");
            _quantidade = LerValorInteiro();
        }

        public DescontoProduto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        public double CalcularValorTotalSemDesconto()
        {
            return _quantidade * _preco;
        }

        public double CalcularDesconto()
        {
            if (_quantidade >= 11 && _quantidade <= 20)
            {
                return 0.1;
            }
            else if (_quantidade >= 21 && _quantidade <= 50)
            {
                return 0.2;
            }
            else if (_quantidade > 50)
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
            return _nome;
        }

        public double ObterPreco()
        {
            return _preco;
        }

        public int ObterQuantidade()
        {
            return _quantidade;
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
