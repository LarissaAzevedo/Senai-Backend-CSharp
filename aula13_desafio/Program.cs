using System;
using aula13_desafio.Controller;

namespace aula13_desafio {
    class Program {
        static void Main (string[] args) {

            PlayerController player = new PlayerController ();

            player.SelecionarPersonagem ();

            player.MostrarInfo ();

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}