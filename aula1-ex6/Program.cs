using System;

namespace aula1_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario, divida, resto;

            Console.WriteLine("Informe o seu salário: ");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe o valor da sua dívida: ");
            divida = int.Parse(Console.ReadLine());

            resto = salario - divida;

            Console.WriteLine($"Após pagar sua dívida, restará R${resto}.");
        }
    }
}
