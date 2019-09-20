using System;

namespace aula5._1 {
    class Program {
        static void Main (string[] args) {
            int[] valores = new int[10];

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite um valor: ");
                valores[i] = int.Parse (Console.ReadLine ());
            }

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("O valor do índice " + i + " é " + valores[i]);
            }
            Console.WriteLine ("O valor do último índice multiplicado por 5 é " + valores[9] * 5);

        }
    }
}