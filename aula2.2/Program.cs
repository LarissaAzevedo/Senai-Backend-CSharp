using System;

namespace aula2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pago;

            Console.WriteLine("Insira o valor a ser pago: ");
            pago = int.Parse(Console.ReadLine());

            if (pago > 100){
                pago = pago - 25;
            }
            Console.WriteLine($"O valor a ser pago é de R${pago}.");
        }
    }
}
