using System;

namespace aula9._2 {
    class Program {
        static void Main (string[] args) {
            DiaDaSemana();
        }

        static void DiaDaSemana () {

            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
        
    }
}