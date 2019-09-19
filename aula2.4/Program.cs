using System;

namespace aula2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.WriteLine("Informe o valor a ser pago: ");
            valor = double.Parse(Console.ReadLine());

            if(valor > 100 && valor < 1000){
                valor = valor - (valor * 0.15);
            }
            Console.WriteLine($"O valor a ser pago é de R${valor}.");
        }
    }
}
