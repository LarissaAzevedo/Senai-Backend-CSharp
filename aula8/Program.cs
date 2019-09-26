using System;

namespace aula8 {
    class Program {
        static void Main (string[] args) {

            string[] v1 = { "A", "B", "C", "D", "E" };

            //foreach apenas lê, não tem contador (para cada)
            //o vetor não tem um limite, ele vai ler enquanto houver dados para serem exibidos
            foreach (string xpto in v1) {
                Console.WriteLine (xpto);
            }
        }
    }
}