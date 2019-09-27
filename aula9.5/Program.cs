using System;

namespace aula9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = {1, 5, 6.5, 3, 3.3, 4.2, 1.9};
            Console.WriteLine(Total(vetor));
        }

        static double Total(double[] v1){
            double soma = 0;

            for(int i = 0; i < v1.Length; i++){
                soma += v1[i];
            }

            return soma;
        }
    }
}
