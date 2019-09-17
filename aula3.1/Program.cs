using System;

namespace aula3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pedido;
            string result;

            Console.Write("Digite o número da opção escolhida:\n1 - Hambúrguer\n2 - Cheese Salada\n3 - Cheese Burguer\n4 - Cheese Bacon\n");
            pedido = int.Parse(Console.ReadLine());

            switch(pedido){
                case 1:
                    result = "Você escolheu hambúrguer!";
                break;

                case 2:
                    result = "Você escolheu cheese salada!";
                break;

                case 3:
                    result = "Você escolheu cheese burguer!";
                break;

                case 4:
                    result = "Você escolheu cheese bacon!";
                break;

                default:
                    result = "Opção inválida!";
                break;
            }
            Console.Write(result);
        }
    }
}
