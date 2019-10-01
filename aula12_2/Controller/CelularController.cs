using System;
using aula12_2.Model;

namespace aula12_2.Controller {
    public class CelularController {
        CelularModel celular = new CelularModel ();

        public void MexerNoCelular () {

            try
            {
                System.Console.WriteLine ("Ligar o celular? true ou false");
            celular.Ligado = bool.Parse (Console.ReadLine ());
            LigarCelular ();

            if (celular.Ligado == true) {

                System.Console.WriteLine ("Fazer ligação? true ou false");
                celular.Ligacao = bool.Parse (Console.ReadLine ());
                Ligacao ();

                System.Console.WriteLine ("Mandar mensagem? true ou false");
                celular.Mensagem = bool.Parse (Console.ReadLine ());
                Mensagem ();
            }
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("Algo deu errado");
            }
        }

        public void LigarCelular () {
            if (celular.Ligado == true) {
                System.Console.WriteLine ("Celular ligado!");
            } else {
                System.Console.WriteLine ("Celular desligado!");
            }
        }

        public void Ligacao () {
            if (celular.Ligado == true && celular.Ligacao == true) {
                System.Console.WriteLine ("Fazendo ligação...");
            } else {
                System.Console.WriteLine ("Não foi possível fazer ligação");
            }
        }

        public void Mensagem () {
            if (celular.Ligado == true && celular.Mensagem == true) {
                System.Console.WriteLine ("Enviando mensagem...");
            } else {
                System.Console.WriteLine ("Não foi possível enviar mensagem");
            }
        }
    }
}