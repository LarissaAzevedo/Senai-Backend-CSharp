using System;
using System.Collections.Generic;
using aula13_2.Model;

namespace aula13_2 {
    class Program {
        static void Main (string[] args) {
            ProdutoModel produto = new ProdutoModel ("Laranja", true);

            List<ProdutoModel> produtos = new List<ProdutoModel> ();
            produtos.Add (new ProdutoModel ("Laranja", false));
            produtos.Add (new ProdutoModel ("Maçã", false));
            produtos.Add (new ProdutoModel ("Melancia", true));
            produtos.Add (new ProdutoModel ("Banana", false));
            produtos.Add (new ProdutoModel ("Morango", false));
            produtos.Add (new ProdutoModel ("Manga", true));
            produtos.Add (new ProdutoModel ("Abacaxi", true));

            foreach (ProdutoModel pro in produtos) {

                if (produto.Reservado == true) {
                    System.Console.WriteLine ($"{pro.NomeProduto}: Reservado: {pro.Reservado}.");
                } else {
                    System.Console.WriteLine ($"{pro.NomeProduto}: Reservado: {pro.Reservado}.");
                }
            }
            
        }
    }
}