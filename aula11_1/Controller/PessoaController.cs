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

            System.Console.WriteLine ("Seu nome: " + pessoa.NomePessoa);
            System.Console.WriteLine ("Sua idade: " + pessoa.IdadePessoa);
            System.Console.WriteLine ("Seu peso: " + pessoa.PesoPessoa);
            System.Console.WriteLine ("Sua altura: " + pessoa.AlturaPessoa);

        }

        public void CalculoIMC () {

            double imc = 0;

            imc = pessoa.PesoPessoa / (pessoa.AlturaPessoa * pessoa.AlturaPessoa);

            System.Console.WriteLine(imc);
            if (imc <= 18.5) {
                System.Console.WriteLine ("\nSua situação: Abaixo do peso");
            } else if (imc >= 18.5 && imc <= 25) {
                System.Console.WriteLine ("\nSua situação: Peso normal");
            } else if (imc >= 26 && imc <= 30) {
                System.Console.WriteLine ("\nSua situação: Sobrepeso");
            } else if (imc >= 31 && imc <= 35) {
                System.Console.WriteLine ("\nSua situação: Obesidade grau I");
            } else if (imc >= 36 && imc <= 39) {
                System.Console.WriteLine ("\nSua situação: Obesidade grau II");
            } else if (imc >= 40) {
                System.Console.WriteLine ("\nSua situação: Obesidade grau III");
            }


        }
    }
}