using System;

namespace aula2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite mais um valor: ");
            n3 = int.Parse(Console.ReadLine());

            //n1 maior valor
            if(n1 > n2 && n1 > n3){
                Console.WriteLine($"O maior valor digitado foi {n1}.");
            }

            //n2 maior valor
            if(n2 > n1 && n2 > n3){
                Console.WriteLine($"O maior valor digitado foi {n2}.");
            }

            //n3 maior valor
            if(n3 > n1 && n3 > n2){
                Console.WriteLine($"O maior valor digitado foi {n3}.");
            }
        }
    }
}
