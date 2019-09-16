using System;

namespace aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entrada = false;
            int idade;
            string retorno = "Entrada não permitida";

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade > 17){
                entrada = true;
            }

            if(entrada == true){
                retorno = "Entrada permitida!";
            } 
            Console.WriteLine(retorno);

        }
    }
}
