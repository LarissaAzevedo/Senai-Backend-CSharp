using System;

namespace aula9._4 {
    class Program {
        static void Main (string[] args) {
            double[] vetor = {1, 5, 6.5, 3, 3.3, 4.2, 1.9};
            System.Console.WriteLine(MaiorValor(vetor));
        }

        static double MaiorValor (double[] v1) {
            double maior = 0;

            for (int i = 0; i < v1.Length; i++) {

                if (v1[0] < 0) {
                    maior = v1[0];
                }

                if (maior < v1[i]) {
                    maior = v1[i];
                }
            }

            return maior;
        }
    }
}