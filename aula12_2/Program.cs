using System;
using aula12_2.Controller;

namespace aula12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController celular = new CelularController();

            celular.LigarCelular();

            celular.MexerNoCelular();
        }
    }
}
