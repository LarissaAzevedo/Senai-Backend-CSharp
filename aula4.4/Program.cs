using System;

namespace aula4._4 {
    class Program {
        static void Main (string[] args) {

            int n = 0;
            int cont = 0;
            int soma = 0;
            Console.WriteLine ("Serão mostrados os valores positivos.");

            for (int i = 0; i <= 4; i++) {
                
                Console.WriteLine ("Digite um valor");

                n = int.Parse (Console.ReadLine ());

                if (n > 0) {
                    Console.Write (n + " é maior que 0\n");
                    cont++;
                    soma += n;
                }
            }

            Console.WriteLine ($"Agora será mostrada a média desses valores: {soma/cont}");

        }

    }
}