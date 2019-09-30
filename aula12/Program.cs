using System;
using aula12.Controller;

namespace aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarroController carro = new CarroController();
            CarroEletricoController carroEletrico = new CarroEletricoController();


            Console.Clear();

            // carro.Ligar();

            // carro.Desligar();

            // carro.Acelerar();

            // carro.CadastrarMotor();

            carroEletrico.CarregarBateria(120);
            carroEletrico.CarregarBateria(15);

            System.Console.WriteLine(carroEletrico.StatusBateria());



        }
    }
}
