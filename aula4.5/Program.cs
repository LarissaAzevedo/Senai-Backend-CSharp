using System;

namespace aula4._5 {
    class Program {
        static void Main (string[] args) {
            
            string nome = "";
            float salario = 0;
            float media = 0;
            string sair = "";

            while (sair != "sim") {

                Console.WriteLine ("Digite seu nome: ");
                nome = Console.ReadLine ();

                Console.WriteLine ("Digite seu salário: ");
                salario = int.Parse (Console.ReadLine ());

                media += salario;
                Console.WriteLine ("Deseja sair da aplicação? Sim ou Não");
                sair = Console.ReadLine ().ToLower ();
            }

            Console.WriteLine ($"A media dos salários é de {media}");
        }
    }
}