using System;

namespace aula5 {
    class Program {
        static void Main (string[] args) {

            double[] media = new double[10];

            //ele armazena no array, não exclui informação
            for (int i = 1; i <= 9; i++) {
                Console.WriteLine ("Digite uma nota: ");
                media[i] = double.Parse (Console.ReadLine ());
            }

            Console.WriteLine (media[3]);
            Console.WriteLine();

            for(int i = 0; i < media.Length; i++){
                Console.WriteLine(media[i]);
            }
        }
    }
}