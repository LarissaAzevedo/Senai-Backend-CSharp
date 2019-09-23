using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa, resultado, final;

            Console.WriteLine("Digite a placa do seu carro"); 
            placa = Console.ReadLine();

            //contagem da quantidade de caracteres do elemento
            int caracteres = placa.Length;

            //pega o ultimo caracter e armazena - metodo substring - 
            final = placa.Substring(caracteres - 1);

            // if(final == "1" || final == "2"){
            //     resultado = "Seu rodízio é na segunda-feira.";
            // }
            // else if(final == "3" || final == "4"){
            //     resultado = "Seu rodízio é na terça-feira.";
            // }
            // else if(final == "5" || final == "6"){
            //     resultado = "Seu rodízio é na quarta-feira.";
            // }
            // else if(final == "7" || final == "8"){
            //     resultado = "Seu rodízio é na quinta-feira.";
            // }
            // else if(final == "9" || final == "0"){
            //     resultado = "Seu rodízio é na sexta-feira.";
            // }
            // else{
            //     resultado = "Inválido";
            // }
            // Console.WriteLine(resultado);

            // ===========================switch case ==================

            switch(final){
                case "1":
                resultado = "Switch - Segunda feira";
                break;
                case "2":
                resultado = "Switch - Segunda feira";
                break;
                case "3":
                resultado = "Switch - Terça feira";
                break;
                case "4":
                resultado = "Switch - Terça feira";
                break;
                case "5":
                resultado = "Switch - Quarta feira";
                break;
                case "6":
                resultado = "Switch - Quarta feira";
                break;
                case "7":
                resultado = "Switch - Quinta feira";
                break;
                case "8":
                resultado = "Switch - Quinta feira";
                break;
                case "9":
                resultado = "Switch - Sexta feira";
                break;
                case "0":
                resultado = "Switch - Sexta feira";
                break;
                default:
                resultado = "Entrada inválida :(";
                break;
            }
            
            Console.WriteLine(resultado);


        }
    }
}
