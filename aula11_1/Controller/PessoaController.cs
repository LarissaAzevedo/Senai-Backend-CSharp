using System;

namespace aula11_1.Controller {
    public class PessoaController {
        PessoaModel pessoa = new PessoaModel ();

        public void ReceberEExibir () {
            System.Console.WriteLine ("Digite seu nome:");
            pessoa.NomePessoa = Console.ReadLine ();

            System.Console.WriteLine ("Digite sua idade:");
            pessoa.IdadePessoa = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite seu peso, em quilogramas:");
            pessoa.PesoPessoa = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite sua altura, em metros:");
            pessoa.AlturaPessoa = double.Parse (Console.ReadLine ());

            System.Console.WriteLine (pessoa.NomePessoa);
            System.Console.WriteLine (pessoa.IdadePessoa);
            System.Console.WriteLine (pessoa.PesoPessoa);
            System.Console.WriteLine (pessoa.AlturaPessoa);

        }

        public void CalculoIMC () {

            double imc = 0;

            imc = pessoa.PesoPessoa / (pessoa.AlturaPessoa * pessoa.AlturaPessoa);
            if (imc < 18.5) {
                System.Console.WriteLine("Abaixo do peso");
            } else if (imc > 18.5 && imc <= 25)
            {
                System.Console.WriteLine("Peso normal");
            } else if (imc >= 26 && imc <= 30)
            {
                System.Console.WriteLine("Sobrepeso");
            }else if (imc >= 31 && imc <= 35)
            {
                System.Console.WriteLine();
            }

        }
    }
}