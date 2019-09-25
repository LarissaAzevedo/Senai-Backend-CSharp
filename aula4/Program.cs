using System;

namespace aula4 {
    class Program {
        static void Main (string[] args) {

            //o que eu fiz 
            
            //laço contado - incremento 
            // for (int cont = 1; cont <= 100; cont++) {
            //     if (cont % 2 != 0) {
            //         Console.WriteLine (cont);
            //     }
            // }
            // //laço contado - decremento 

            // for (int cont = 100; cont >= 0; cont--) {
            //     if (cont % 2 != 0) {
            //         Console.WriteLine (cont);
            //     }
            // }

            //condicional - while
            //o que eu fiz
            // double nota = 1;
            // double total = 1.2d;
            // int cont1 = -1;

            // while (nota != -1) {
            //     Console.Write ("Digite uma nota: ");
            //     nota = int.Parse (Console.ReadLine ());
            //     cont1++;
            //     total = total + nota;
            // }
            // Console.WriteLine (total / cont1);
            // Console.WriteLine (total);
            // Console.WriteLine (cont1);

            // //o que o professor fez
            // double acumuladora = 0;
            // double nota = 0;
            // int cont2 = 0;
            // string sair = "";

            // while (sair != "sim") {
            //     Console.Write ("Digite uma nota: ");
            //     nota = double.Parse(Console.ReadLine ());

            //     acumuladora += nota;
            //     cont2++;
            //     Console.WriteLine ("Deseja sair da aplicação?\nSim\nNão");
            //     sair = Console.ReadLine().ToLower();
            // }
            // Console.WriteLine("Média das notas: " + (acumuladora / cont2));

            int numero = 0;
            int cont = 1;
            int acumula = 0;
            do {
                Console.WriteLine ("Digite um número: ");
                numero = int.Parse (Console.ReadLine ());
                cont++;
                if (numero % 3 == 0) {
                    acumula = acumula + numero;
                }
            } while (cont <= 5);
            Console.WriteLine(acumula);
        }
    }
}