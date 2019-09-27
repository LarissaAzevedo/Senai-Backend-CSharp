using System;

namespace aula9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MostraInfo();
            MostraInfo("Larissa", "Azevedo");
            MostraInfo(20, 51, 1.73);
        }

        static void MostraInfo(){
            System.Console.WriteLine("A razão social da escola Senai...");
        }

        static  void  MostraInfo(string nome, string sobrenome){
            
            Console.WriteLine($"Olá {nome} {sobrenome}!");
        }

        static void  MostraInfo (int idade, double peso, double altura){
            
            Console.WriteLine($"Idade: {idade}\nPeso: {peso}\nAltura: {altura}");
        }
    }
}
