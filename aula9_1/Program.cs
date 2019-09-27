using System;

namespace aula9_1 {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Insira um valor:");
            double valor = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite uma porcentagem:");
            double porcentagem = double.Parse (Console.ReadLine ());

            // Desconto (valor,porcentagem);

            System.Console.WriteLine("Valor a ser pago: R$" + Desconto (valor,porcentagem));
        }

        /// <summary>
        /// Calcula o desconto com os valores que o usuário digitou
        /// </summary>
        /// <param name="valor">Valor a ser aplicado desconto</param>
        /// <param name="porcentagem">Percentual de desconto</param>
        /// <returns>Desconto sobre o valor</returns>
        static double Desconto (double val, double por) {
            double desconto;

            desconto = val - (val / por);

            return desconto;

        }
    }
}