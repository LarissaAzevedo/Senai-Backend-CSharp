using System;

namespace aula4._7 {
    class Program {
        static void Main (string[] args) {

            int n = 0;
            int i = 0;
            int soma = 0;
            int produto = 1;

            for (i = 0; i <= 100; i++) {
                
                Console.WriteLine ("Digite um número maior que 0.");
                n = int.Parse (Console.ReadLine ());

                if (n % 2 != 0) { //impar
                    soma += n;
                }
                if (n % 3 == 0) { //multiplo de 3
                    produto = produto * n;
                }
            }
            Console.WriteLine ($"Soma dos números ímpares: {soma}");
            Console.WriteLine ($"Produto dos números múltiplos de 3: {produto}");
        }
    }
}