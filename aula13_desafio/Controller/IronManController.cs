using System;
using aula13_desafio.Model;

namespace aula13_desafio.Controller {
    public class IronManController {
        PlayerModel player = new PlayerModel ();

        public void Info () {
            Console.ForegroundColor = ConsoleColor.Red;
            player.NomeHeroi = "\nAnthony Edward Stark";
            player.Equipe = "\nViuva Negra, Homem Formiga, Soldado Invernal, Falcão\n";
            System.Console.WriteLine (player.NomeHeroi);
            System.Console.WriteLine (player.Equipe);

        }

        public void AcaoPersonagem () {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine ("\nVocê selecionou Homem de Ferro.\nO que deseja fazer?\n1 - Pular\n2 - Voar\n3 - Atirar\n");
            int resposta = int.Parse (Console.ReadLine ());

            if (resposta == 1) {
                System.Console.WriteLine ("Você escolheu pular");
                Pular ();
            } else if (resposta == 2) {
                Voar ();
            } else if (resposta == 3) {
                Atirar ();
            } else {
                System.Console.WriteLine ("Opção inválida!\n");
            }
        }

        public void Pular () {
            System.Console.WriteLine ("*Saltando*\n");
        }

        public void Voar () {
            System.Console.WriteLine ("*Voando*\n");
        }

        public void Atirar () {
            System.Console.WriteLine ("*Atirando*\n");
        }

    }
}