using System;
using aula12_4.Model;

namespace aula12_4.Controller
{
    public class CientificaController : CalculadoraController
    
    {
        CalculadoraModel calc = new CalculadoraModel();
        public void Cientifica(){
            
            System.Console.WriteLine("Calculadora científica!");
            PegaValores();

            calc.Resultado = Math.Pow(calc.Valor1,calc.Valor2);
            System.Console.WriteLine("O resultado da potênciação é " + calc.Resultado);

        }
    }
}