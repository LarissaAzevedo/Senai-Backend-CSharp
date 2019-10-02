using System;
using aula13_desafio.Model;

namespace aula13_desafio.Controller {
    public class PlayerController {

        PlayerModel player = new PlayerModel ();

        CapitaoController Cap = new CapitaoController ();

        IronManController Iron = new IronManController ();

        public void SelecionarPersonagem () {

            System.Console.WriteLine ("Selecionar personagem\n1 - Capitão América\n2 - Homem de Ferro\n");
            int resposta = int.Parse (Console.ReadLine ());

            if (resposta == 1) {
                player.CapitaoAmerica = true;
            } else if (resposta == 2) {
                player.HomemDeFerro = true;
            } else {
                System.Console.WriteLine ("Resposta inválida!");
            }

        }
        public void MostrarInfo () {
            if (player.CapitaoAmerica == true) {
                Cap.Info ();

                System.Console.WriteLine ("Jogar? s ou n");
                string res = Console.ReadLine ();
                if (res == "s") {
                    Jogar ();
                }

            } else if (player.HomemDeFerro == true) {
                Iron.Info ();
                System.Console.WriteLine ("Jogar? s ou n");
                string res = Console.ReadLine ();
                if (res == "s") {
                    Jogar ();
                }
            }

        }

        public void Jogar () {

            if (player.CapitaoAmerica == true) {
                Cap.AcaoPersonagem ();
            } else if (player.HomemDeFerro == true) {
                Iron.AcaoPersonagem ();
            }

        }

    }
}