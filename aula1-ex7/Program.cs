using System;

namespace aula1_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int NPassageiros;
            double passagem = 4.30, ValorArrecadado;

            Console.WriteLine("Informe quantos passageiros entraram: ");
            NPassageiros = int.Parse(Console.ReadLine());

            ValorArrecadado = NPassageiros * passagem;

            Console.WriteLine($"O valor arrecadado foi de R${ValorArrecadado}.");
        }
    }
}
