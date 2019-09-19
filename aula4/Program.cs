using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //laço contado - incremento 
            for(int cont = 1; cont <= 100; cont++){
                if(cont % 2 != 0){
                    Console.WriteLine(cont);
                }
            }
            //laço contado - decremento 

            for(int cont = 100; cont >= 0; cont--){
                if(cont % 2 != 0){
                    Console.WriteLine(cont);
                }
            }
        }
    }
}
