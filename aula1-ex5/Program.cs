using System;

namespace aula1_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nmVendedor;
            double salario, total;
            int vendas;

            Console.WriteLine("Insira seu nome: ");
            nmVendedor = Console.ReadLine();

            Console.WriteLine("Insira seu salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantas vendas foram realizadas: ");
            vendas = int.Parse(Console.ReadLine());

            total = salario + (vendas * 0.10);

            Console.WriteLine($"{nmVendedor},O valor a ser recebido é de R${total}.");
        }
    }
}
