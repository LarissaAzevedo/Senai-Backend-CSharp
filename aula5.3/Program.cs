using System;

namespace aula5._3 {
    class Program {
        static void Main (string[] args) {
            //me parece matriz isso ai
            string[] NomeProduto = new string[3];
            string[] CorProduto = new string[3];
            string[] TamanhoProduto = new string[3];
            float[] PrecoProduto = new float[3];

            for (int i = 0; i <= 2; i++) {
                Console.WriteLine ("Digite o nome do produto: ");
                NomeProduto[i] = Console.ReadLine ();

                Console.WriteLine ("Informe a cor do produto: ");
                CorProduto[i] = Console.ReadLine ();

                Console.WriteLine ("Insira o tamanho do produto: ");
                TamanhoProduto[i] = Console.ReadLine ();

                Console.WriteLine ("Insira o preço do produto: ");
                PrecoProduto[i] = float.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 2; i++) {
                Console.WriteLine ($"Nome do produto: {NomeProduto[i]}. Cor: {CorProduto[i]}. Tamanho: {TamanhoProduto[i]}. Preço: {PrecoProduto[i]}\n");
            }
        }
    }
}