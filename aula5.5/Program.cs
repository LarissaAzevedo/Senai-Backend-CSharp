using System;

namespace aula5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int cont = 0;

            for(int i = 0; i <=9; i++){
                cont++;
                vetor[i] = (cont - 1) * 2;
            }

            for(int i = 0; i <= 9; i++){
                Console.WriteLine("Índice " + i + " - " + vetor[i]);
            }
        }
    }
}
