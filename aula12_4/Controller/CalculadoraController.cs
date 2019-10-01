using System;
using aula12_4.Controller;
using aula12_4.Model;

namespace aula12_4.Controller {
    public class CalculadoraController {
        CalculadoraModel calc = new CalculadoraModel ();

        public void ChamaCalc () {
            System.Console.WriteLine ("1 - Calculadora básica \n2 - Calculadora Científica");
            calc.Calc = int.Parse (Console.ReadLine ());
            if (calc.Calc == 1) {
                PegaValores ();
                Calcula ();
            } else if (calc.Calc == 2) {
                CientificaController cien = new CientificaController ();
                cien.Cientifica ();
            }

        }
        public void PegaValores () {
            System.Console.WriteLine ("Digite um valor:");
            calc.Valor1 = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite outro valor:");
            calc.Valor2 = double.Parse (Console.ReadLine ());

        }
        public void Calcula () {

            System.Console.WriteLine ("Digite uma operação:");
            calc.op = Console.ReadLine ();

            //verifica a operação que o usuário escolheu e transforma em true
            if (calc.op == "+") {
                calc.Soma = true;
            } else if (calc.op == "-") {
                calc.Subtracao = true;
            } else if (calc.op == "*" || calc.op == "x") {
                calc.Multiplicacao = true;
            } else if (calc.op == "/") {
                calc.Divisao = true;
            }

            if (calc.Soma == true) {
                System.Console.WriteLine (calc.Resultado = calc.Valor1 + calc.Valor2);
            } else if (calc.Subtracao == true) {
                System.Console.WriteLine (calc.Resultado = calc.Valor1 - calc.Valor2);
            } else if (calc.Multiplicacao == true) {
                System.Console.WriteLine (calc.Resultado = calc.Valor1 * calc.Valor2);
            } else if (calc.Divisao == true) {
                System.Console.WriteLine (calc.Resultado = calc.Valor1 / calc.Valor2);
            }
        }
    }
}