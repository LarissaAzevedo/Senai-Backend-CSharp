using System;

namespace aula2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                Console.WriteLine($"O maior valor digitado foi {n1}");
            } else{
                Console.WriteLine($"O maior valor digitado foi {n2}");
            }
        }
    }
}
