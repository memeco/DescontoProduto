using System;

namespace DescontoProduto
{
    public class DescontoProduto
    {
        private string nome;
        private double preco;
        private int quantidade;

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
    }
}
