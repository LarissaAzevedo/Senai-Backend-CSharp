using System;

namespace aula5._1 {
    class Program {
        static void Main (string[] args) {
            string[] series1 = new string[10];
            string[] series2 = new string[10];

            // populando o array
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite o nome de uma série: ");
                series1[i] = Console.ReadLine ();
            }

            //copiando o conteúdo do primeiro array no segundo
            for (int i = 0; i <= 9; i++) {
                series2[i] = series1[i];
            }

            //exibindo o conteúdo do segundo vetor
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine (i + " - " + series2[i]);
            }
        }
    }
}