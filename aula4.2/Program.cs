using System;

namespace aula4._2 {
    class Program {
        static void Main (string[] args) {
            int cont = 0;
            int cont2 = 0;
            int cont3 = 0;

            int i = 0;
            int j = 0;
            int k = 0;

            Console.WriteLine ("Digite um número: ");
            int n = int.Parse (Console.ReadLine ());
            Console.WriteLine ($"\nEsta é a tabuada de {n} - feita com for");

            //Tabuada - for
            for (i = 0; i < 10; i++) {
                cont++;
                Console.WriteLine (n + " X " + cont + " = " + (cont * n));
            }

            //Tabuada - while
            Console.WriteLine ($"\nEsta é a tabuada de {n} - feita com while");

            while (j < 10) {
                j++;
                cont2++;
                Console.WriteLine (n + " X " + cont2 + " = " + (cont2 * n));
            }

            //Tabuada - do while
            Console.WriteLine ($"\nEsta é a tabuada de {n} - feita com do while");

            do {
                k++;
                cont3++;
                Console.WriteLine (n + " X " + cont3 + " = " + (cont3 * n));
            } while (k < 10);
        }
    }
}