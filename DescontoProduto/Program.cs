using System;

namespace DescontoProduto
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exibição do menu de opções
            Console.WriteLine("**Menu de Opções**");
            Console.WriteLine("1 - Cadastrar novo produto");
            Console.WriteLine("2 - Sair");

            // Leitura da opção do usuário
            int opcao = LerValorInteiro();

            while (opcao < 1 || opcao > 2)
            {
                Console.WriteLine("Opção inválida. Digite novamente: ");
                opcao = LerValorInteiro();
            }

            switch (opcao)
            {
                case 1:
                    // Cadastrar novo produto
                    Console.Clear();
                    CadastrarNovoProduto();
                    break;
                case 2:
                    // Sair do programa
                    Console.WriteLine("Saindo do programa...");
                    break;
            }
        }

        static void CadastrarNovoProduto()
        {
            // Leitura do nome do produto
            Console.WriteLine("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            // Leitura do preço do produto
            Console.WriteLine("Digite o preço do produto: ");
            double precoProduto = LerValorDouble();

            // Leitura da quantidade do produto
            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidadeProduto = LerValorInteiro();

            // Criação da instância da classe DescontoProduto
            DescontoProduto descontoProduto = new DescontoProduto(nomeProduto, precoProduto, quantidadeProduto);

            // Exibição dos resultados
            Console.WriteLine("Nome do produto: {0}", descontoProduto.ObterNome());
            Console.WriteLine("Preço do produto: R${0}", descontoProduto.ObterPreco().ToString("F2"));
            Console.WriteLine("Quantidade do produto: {0}", descontoProduto.ObterQuantidade());
            Console.WriteLine("Valor total sem desconto: R${0}", descontoProduto.CalcularValorTotalSemDesconto().ToString("F2"));
            Console.WriteLine("Desconto: {0}%", (descontoProduto.CalcularDesconto() * 100).ToString("F2"));
            Console.WriteLine("Valor total com desconto: R${0}", descontoProduto.CalcularValorTotalComDesconto().ToString("F2"));

            // Pressione qualquer tecla para continuar
            Console.ReadKey();
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
