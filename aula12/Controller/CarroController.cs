using System;
using aula12.Model;

namespace aula12.Controller {
    public class CarroController {
        CarroModel carro = new CarroModel ();

        MotorModel motor = new MotorModel ();

        public void Ligar () {
            carro.Ligado = true;
            System.Console.WriteLine ("Ligando carro!");
        }

        public void Desligar () {
            carro.Ligado = false;
            System.Console.WriteLine ("Desligando carro...");
        }

        public void Acelerar () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro acelerando.");
            } else {
                System.Console.WriteLine ("Impossível acelerar, carro desligado.");
            }
        }

        public void Frear () {
            if (carro.Ligado == true) {
                System.Console.WriteLine ("Carro freando...");
            } else {
                System.Console.WriteLine ("Carro parado, impossível frear.");
            }
        }

        public void CadastrarMotor () {
            System.Console.WriteLine ("Digite a quantidade de cavalos que há no motor:");
            motor.Cavalos = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite quantos cilindros tem o carro:");
            motor.Cilindros = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o modelo de pistão que há no carro:");
            motor.Pistao = Console.ReadLine ();

        }
    }

}