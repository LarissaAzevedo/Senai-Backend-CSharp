using System;
using aula12_1.Controller;

namespace aula12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController aluno = new AlunoController();

            aluno.LerAluno();

            aluno.ExibirAluno();
        }
    }
}
