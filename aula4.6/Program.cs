using System;

namespace aula4._6 {
    class Program {
        static void Main (string[] args) {
            int i = 0;
            int fn = 1;
            int ant = 0;
            int atual = 0;

            int j = 0;
            int fn2 = 1;
            int ant2 = 0;
            int atual2 = 0;

            int k = 0;
            int fn3 = 1;
            int ant3 = 0;
            int atual3 = 0;

            Console.WriteLine ("Sequencia de Fibonacci - Com for");
            for (i = 0; i <= 10; i++) {
                ant = atual;
                atual = fn;
                fn = ant + atual;

                Console.WriteLine (fn);
            }

            Console.WriteLine ("Sequencia de Fibonacci - Com while");
            while ( j <= 10) {
                ant2 = atual2;
                atual2 = fn2;
                fn2 = ant2 + atual2;
                j++;
                Console.WriteLine (fn2);
            }

            Console.WriteLine ("Sequencia de Fibonacci - Com do while");
            do {
                ant3 = atual3;
                atual3 = fn3;
                fn3 = ant3 + atual3;
                k++;
                Console.WriteLine (fn3);
            } while (k <= 10);

        }
    }
}