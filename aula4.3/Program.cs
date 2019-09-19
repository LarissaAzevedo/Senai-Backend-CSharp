using System;

namespace aula4._3 {
    class Program {
        static void Main (string[] args) {
            int n = 1;
            int cont = 0;

            Console.WriteLine ("Digite um número: ");
            cont = int.Parse (Console.ReadLine ());

            do {
                if (n % 5 == 0) {
                    Console.WriteLine (n);
                }
                n++;
            } while (n <= cont);

        }
    }
}