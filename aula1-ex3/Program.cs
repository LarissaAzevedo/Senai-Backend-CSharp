using System;

namespace aula1_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, vendas, total;

            Console.WriteLine("Digite o valor do seu salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantas vendas foram feitas: ");
            vendas = double.Parse(Console.ReadLine());

            total = salario + (vendas * 0.5);

            Console.WriteLine($"Você receberá R${total}.");
        }
    }
}
