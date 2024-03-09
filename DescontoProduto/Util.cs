using System;

namespace DescontoProduto
{
    public static class Util // Class named Util
    {
        public static double LerValorDouble()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido. Digite novamente: ");
            }
            return valor;
        }

        public static int LerValorInteiro()
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
