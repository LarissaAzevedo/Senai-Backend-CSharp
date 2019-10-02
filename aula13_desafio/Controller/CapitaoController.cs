using System;
using aula13_desafio.Model;

namespace aula13_desafio.Controller {
    public class CapitaoController {
        PlayerModel player = new PlayerModel ();

        public void Info () {
            Console.ForegroundColor = ConsoleColor.Blue;
            player.NomeHeroi = "\nSteve Rogers";
            player.Equipe = "\nViuva Negra, Homem Formiga, Soldado Invernal, Falcão";
            player.VidaPlayer = 100;

            System.Console.WriteLine ("\n" + player.NomeHeroi);
            System.Console.WriteLine ("\n" + player.Equipe);
            System.Console.WriteLine ("\n" + player.VidaPlayer + " Hp\n");

        }

        public void AcaoPersonagem () {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine ("\nVocê selecionou Capitão América.\nO que deseja fazer?\n\n1 - Pular\n2 - Lançar Escudo\n3 - Defender-se com o escudo\n");
            int resposta = int.Parse (Console.ReadLine ());
            if (resposta == 1) {
                System.Console.WriteLine ("\nVocê escolheu pular\n");
                Pular ();
            } else if (resposta == 2) {
                LancandoEscudo ();
            } else if (resposta == 3) {
                Defender ();
            } else {
                System.Console.WriteLine ("\nOpção inválida!\n");
            }
        }
        public void Pular () {
            System.Console.WriteLine ("\n*Pulando*\n");
        }

        public void LancandoEscudo () {
            System.Console.WriteLine ("\n*Lançando escudo*\n");
        }

        public void Defender () {
            System.Console.WriteLine ("\n*Defendendo*\n");
        }

    }
}