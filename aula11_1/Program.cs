using System;
using aula11_1.Controller;

namespace aula11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PessoaController pessoa = new PessoaController();

            pessoa.ReceberEExibir();

            pessoa.CalculoIMC();


        }
    }
}
