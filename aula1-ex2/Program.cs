using System;

namespace aula1_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor, acrescimo, venda;

            Console.WriteLine("Insira o valor do produto: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o percentual de acréscimo: ");
            acrescimo = float.Parse(Console.ReadLine());

            venda = valor + (valor / acrescimo);

            Console.WriteLine($"O valor de venda é de R${venda}.");

        }
    }
}
