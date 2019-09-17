using System;

namespace aula3.projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doacao = false;
            bool  venda = false;
            string res;
            string doa;
            string resposta;

            Console.WriteLine("\nVocê gostaria de encaminhar seu produto para venda?\n1 - Sim\n2 - Não");
            res = Console.ReadLine();

            Console.WriteLine("\nVocê gostaria de encaminhar seu produto para doação?\n1 - Sim\n2 - Não");
            doa = Console.ReadLine();

            switch(res){
                case "1":
                venda = true;
                break;

                case "2":
                venda = false;
                break;

                default:
                resposta = "Opção inválida.";
                break;
            }

            switch(doa){
                case "1":
                doacao = true;
                break;

                case "2":
                doacao = false;
                break;

                default:
                resposta = "Opção inválida.";
                break;
            }
            if(venda == true && doacao == true){
                resposta = "Seu produto será encaminhado para venda e para doação.";
            }else if(venda == true && doacao == false){
                resposta = "Seu produto será encaminhado para venda apenas.";
            }else if(venda == false && doacao == true){
                resposta = "Seu produto será encaminhado para doação apenas.";
            } else{
                resposta = "Seu produto não será encaminhado.";
            }

            Console.WriteLine(resposta);
        }
    }
}
