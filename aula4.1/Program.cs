using System;

namespace aula4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serão exibidos os cubos dos números de 0 a 100");
            for(int i = 0; i <= 100; i++){
                Console.WriteLine(i + "³ = " + (i*i*i));
            }
        }
    }
}
