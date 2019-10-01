using System;
using aula12_3.Model;

namespace aula12_3.Controller {
    public class ProdutoController {
        ProdutoModel produto = new ProdutoModel ();

        public void ReservarProduto () {

            try {

                System.Console.WriteLine ("Temos o seguinte produto disponível:");
                System.Console.WriteLine ($"{produto.NomeProduto}, Qtde: {produto.QtdeProduto}");
                System.Console.WriteLine ("Gostaria de efetuar uma reserva? Sim ou Não");
                produto.resposta = Console.ReadLine ();

                if (produto.resposta == "Sim") {
                    produto.Reservado = true;
                } else if (produto.resposta == "Não") {
                    produto.Reservado = false;
                }

                if (produto.Reservado == true) {
                    System.Console.WriteLine ("O produto foi reservado!");

                } else {
                    System.Console.WriteLine ("O produto não foi reservado");

                }

            } catch (System.Exception) {

                System.Console.WriteLine ("Resposta inválida");

            }

        }
    }
}