using System;

namespace aula1_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar, valor;

            Console.WriteLine("Digite o valor a ser convertido: ");
            real = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação atual do dólar: ");
            dolar = double.Parse(Console.ReadLine());

            valor = real * dolar;

            Console.WriteLine($"O valor convetido é de U${valor}.");
        }
    }
}
