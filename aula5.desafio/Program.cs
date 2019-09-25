using System;

namespace aula5.desafio {
    class Program {
        static void Main (string[] args) {
            string[] NomePassageiro = new string[5];
            string[] Origem = new string[5];
            string[] Destino = new string[5];
            DateTime[] DataIda = new DateTime[5];
            DateTime[] DataVolta = new DateTime[5];

            string sair = "";

            while (sair != "0") {
                Console.WriteLine ("Bem vindo ao nosso sistema de passagem!\n\nMENU\n\n1 - Cadastrar passagens\n2 - Listar passagens\n0 - Sair\n\n");

                sair = Console.ReadLine ();

                switch (sair) {
                    case "1":
                        for (int i = 0; i <= 4; i++) {
                            Console.WriteLine ("Nome do passageiro: ");
                            NomePassageiro[i] = Console.ReadLine ();

                            Console.WriteLine ("Origem do passageiro: ");
                            Origem[i] = Console.ReadLine ();

                            Console.WriteLine ("Destino do passageiro: ");
                            Destino[i] = Console.ReadLine ();

                            Console.WriteLine ("Data de ida: ");
                            DataIda[i] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Data de volta: ");
                            DataVolta[i] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Dados cadastrados com sucesso!");
                        }
                        break;

                    case "2":
                        //lista
                        for (int i = 0; i <= 4; i++) {
                            if (NomePassageiro[i] != "" && Origem[i] != "" && Destino[i] != "" && DataIda[i] != null && DataVolta[i] != null) {
                                Console.WriteLine ("Passagem nº" + (i + 1));
                                Console.WriteLine ($"{NomePassageiro[i]}, {Origem}, {Destino}, {DataIda}, {DataVolta}.\n");
                            }
                        }
                        break;
                    case "0":
                        Console.WriteLine ("Obrigada por usar nosso sistema!");
                        break;

                    default:
                        Console.WriteLine ("Opção inválida.");
                        break;
                }
            }

        }
    }
}