using System;

namespace aula1_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());

            n2 = n1 * 3;

            Console.WriteLine($"O triplo do número digitado é {n2}");

            
        }
    }
}
