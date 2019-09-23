using System;

namespace aula5._7 {
    class Program {
        static void Main (string[] args) {
            int[] vetor1 = new int[10];
            int indice = 0;
            int maior = 0;
            // int i = 0;

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Insira um valor: ");
                vetor1[i] = int.Parse (Console.ReadLine ());

                if(i == 0){
                    maior = vetor1[i];
                }

                if (maior < vetor1[i]) {
                    indice = i;
                    maior = vetor1[i];
                }
            }
            Console.WriteLine(maior + " é o maior número, índice =  " + indice);
            Console.WriteLine($"{maior} é o maior valor, índice {indice}");
        }
    }
}