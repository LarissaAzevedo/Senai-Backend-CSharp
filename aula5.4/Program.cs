using System;

namespace aula5._4 {
    class Program {
        static void Main (string[] args) {
            string[] a = new string[15];
            string[] b = new string[15];
            string[] c = new string[30];

            //popula o primeiro vetor
            for (int i = 0; i <= 14; i++) {
                Console.WriteLine ("Digite um nome de série: ");
                a[i] = Console.ReadLine ();
            }
            //popula o segundo vetor
            for (int i = 0; i <= 14; i++) {
                Console.WriteLine ("Digite um nome de filme: ");
                b[i] = Console.ReadLine ();
            }
            //popula o terceiro vetor
            for (int i = 0; i <= 14; i++) {
                c[i] = a[i];
                
            }
            for (int i = 0; i <= 14; i++) { 
                c[i + 15] = b[i];
            }

            //exibe o vetor
            for (int i = 0; i <= 29; i++) {
                Console.WriteLine (c[i]);
            }

        }
    }
}