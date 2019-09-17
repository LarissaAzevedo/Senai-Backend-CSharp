using System;

namespace aula3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoPlaneta;
            double pesoTerra;
            double grav = 0;
            int planeta;
            string nomePlaneta = "";

            Console.Write("Informe o seu peso: ");
            pesoTerra = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora escolha o número de um planeta:\n1 - Mercúrio\n2 - Vênus\n3 - Marte\n4 - Júpiter\n5 - Saturno\n6 - Urano");
            planeta = int.Parse(Console.ReadLine());

            switch(planeta){
                case 1:
                grav = 0.37;
                nomePlaneta = "Mercúrio";
                break;

                case 2:
                grav = 0.88;
                nomePlaneta = "Vênus";
                break;

                case 3:
                grav = 0.38;
                nomePlaneta = "Marte";
                break;

                case 4:
                grav = 2.64;
                nomePlaneta = "Júpiter";
                break;

                case 5:
                grav = 1.15;
                nomePlaneta = "Saturno";
                break;

                case 6:
                grav = 1.17;
                nomePlaneta = "Urano";
                break;

                default:
                Console.Write("Opção inválida");
                break;
            }
            pesoPlaneta = (pesoTerra / 10) * grav;

            Console.Write($"Seu peso no planeta {nomePlaneta} é de {pesoPlaneta}kg.");
            
        }
    }
}
