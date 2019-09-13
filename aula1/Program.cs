using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //somente declaramos, sem atribuição de valor
            int num1;
            //declarada e com valor atribuído
            int num2 = 5;
            //declaradas diversas variáveis de mesmo tipo, com ou sem valor atribuido
            int num3, num4;
            //variavel do tipo decimal(real)
            float media;
            //variavel de retorno verdadeiro ou falso - tipo lógico
            bool resultado = false;
            //variavel do tipo texto
            string nomeAluno;
            //escreve em uma linha e quebra-a
            Console.WriteLine("Bem vindos à nossa primeira aplicação!");
            //continua escrevendo na mesma linha
            Console.Write("Digite seu nome, corno: ");
            //pega o dado digitado pelo usuário e salva na variável
            nomeAluno = Console.ReadLine();
            //concatenação
            Console.WriteLine(nomeAluno + ", agora digite sua primeira nota:");
            //converte para inteiro antes de armazenar o valor na variável
            num1 = int.Parse(Console.ReadLine());
            //interpolação
            Console.WriteLine($"Sua primeira nota é {num1} .");

            Console.WriteLine("Digite sua segunda nota: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num4 = int.Parse(Console.ReadLine());

            media = (num1 + num3 + num4)/3;

            Console.WriteLine("Sua média é de " + media + ".");

        }
    }
}