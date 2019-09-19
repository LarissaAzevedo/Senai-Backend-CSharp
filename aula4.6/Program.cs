using System;

namespace aula4._6 {
    class Program {
        static void Main (string[] args) {
            int i = 0;
            int fn = 1;
            int ant = 0;
            int atual = 0;

            Console.WriteLine ("Sequencia de Fibonacci");
            for (i = 0; i <= 10; i++) {
                ant = atual;
                atual = fn ;
                fn = ant + atual;

                Console.WriteLine (fn);
            }
        }
    }
}