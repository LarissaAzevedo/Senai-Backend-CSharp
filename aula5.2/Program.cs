using System;

namespace aula5._2 {
    class Program {
        static void Main (string[] args) {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[20];

            //popula o primeiro vetor
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Vetor 1 - Digite um numero: ");
                vetor1[i] = int.Parse (Console.ReadLine ());
            }
            Console.WriteLine ("Fim vetor 1");

            //popula o segundo vetor
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Vetor 2 - Digite um numero: ");
                vetor2[i] = int.Parse (Console.ReadLine ());
            }
            Console.WriteLine ("Fim vetor 2");

            //adiciona o conteúdo do primeiro vetor no terceiro
            for (int i = 0; i <= 9; i++) {
                vetor3[i] = vetor1[i];
            }

            //adiciona o conteúdo do segundo vetor no terceiro - adicionar o TAMANHO já ocupado no vetor
            for (int i = 0; i <= 9; i++) {
                vetor3[i + 10] = vetor2[i];
            }

            //exibe o vetor 3 - usar o tamanho do vetor -1 mesmo que ele receba outros vetores
            for (int i = 0; i <= 19; i++) {
                Console.WriteLine (vetor3[i]);
            }

        }
    }
}