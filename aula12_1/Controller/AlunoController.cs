using System;
using aula12_1.Model;

namespace aula12_1.Controller {
    public class AlunoController {
        AlunoModel aluno = new AlunoModel ();

        public void LerAluno () {

            try {

                System.Console.WriteLine ("Digite Seu nome:");
                aluno.NomeAluno = Console.ReadLine ();

                System.Console.WriteLine ("Digite o nome do seu curso:");
                aluno.NomeCurso = Console.ReadLine ();

                System.Console.WriteLine ("Digite a sua idade:");
                aluno.IdadeAluno = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite seu RG");
                aluno.RGAluno = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Você é bolsista? true ou false");
                aluno.Bolsista = bool.Parse (Console.ReadLine ());

            } catch (System.Exception ex) {
                System.Console.WriteLine("Algo deu errado.\n" + ex);
            }

        }

        public void ExibirAluno () {
            System.Console.WriteLine ("Nome: " + aluno.NomeAluno);
            System.Console.WriteLine ("Curso: " + aluno.NomeCurso);
            System.Console.WriteLine ("Idade: " + aluno.IdadeAluno);
            System.Console.WriteLine ("RG: " + aluno.RGAluno);

            if (aluno.Bolsista == true) {
                System.Console.WriteLine ("Você é bolsista.");
            } else {
                System.Console.WriteLine ("Você não é bolsista.");
            }
        }

    }
}