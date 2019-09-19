using System;

namespace aula4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nEsta é a tabuada de {n}");

            for(int i = 0; i < 10; i++){
                cont++;
                Console.WriteLine(n + " X " + cont + " = " + (cont*n));
            }
        }
    }
}
