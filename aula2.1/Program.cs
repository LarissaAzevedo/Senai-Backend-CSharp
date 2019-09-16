using System;

namespace aula2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, despesa, saldo;
            bool result = false;
            string resultado = "Saldo negativo - Déficit";

            Console.WriteLine("Digite seu salário: ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua despesa: ");
            despesa = float.Parse(Console.ReadLine());

            saldo = salario - despesa;

            if(saldo > 0){
                result = true;
            }

            if(result == true){
                resultado = "Saldo positivo - Superávit";
            }
            Console.Write(resultado);

        }
    }
}
