using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3)/3;

            if(media >= 6){
                Console.WriteLine($"Aprovado, média {media}");
            }
            
            else{
                Console.WriteLine($"Reprovado, média {media}");
            }
        }
    }
}
