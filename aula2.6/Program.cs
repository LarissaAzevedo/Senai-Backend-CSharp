using System;

namespace aula2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            
            Console.WriteLine("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade < 10){
                Console.WriteLine("Sua classificação é: Everyone");
            }
            if(idade >= 10 && idade <= 13){
                Console.WriteLine("Sua classificação é: E 10+");
            }
            if(idade > 13 && idade <= 17){
                Console.WriteLine("Sua classificação é: Teen");
            }
            if(idade > 17){
                Console.WriteLine("Sua classificação é: Mature 17+");
            }            
        }
    }
}
