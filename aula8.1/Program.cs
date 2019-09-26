using System;

namespace aula8._1 {
    class Program {
        static void Main (string[] args) {

            //tratamento de erro
            int numero = 0;

            try {
                Console.WriteLine ("Digite um número: ");
                numero = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Aeee!");

            } catch (Exception ex) {
                //a variável ex armazena o erro e é exibido na mensagem quando dá erro

                Console.WriteLine ("Ops, tu é corno!" + ex);

            }

        }
    }
}