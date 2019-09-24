using System;

namespace aula6 {
    class Program {
        static void Main (string[] args) {
            //chamando a primeira função que dá BOM DIA
            Console.WriteLine (BomDia ());

            //chamando a função void que retorna data e hora atuais
            ImprimirDataHora ();

            //chamamos nossa função que calcula a média
            double[] numeros = { 2, 5, 2 , 8, 7, 6, 8, 8};

            Console.WriteLine ("Média do vetor: " + CalculaMedia (numeros));

            Console.WriteLine("Soma dos valores: "+ SomaValores(numeros));
        }

        /// <summary>
        /// função que soma valores de um vetor
        /// </summary>
        /// <param name="valores">vetor de valores</param>
        /// <returns>soma dos valores do vetor</returns>
        static double SomaValores(double[] valores){
            double result = 0;

            for(int i = 0; i < valores.Length; i++){
                result += valores[i];
            }

            return result;
        }

        /// <summary>
        /// função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>retorna olá bom dia</returns>
        static string BomDia () {
            return "Olá, bom dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao"></param>
        /// <returns>saudação de acordo com a hora: dia, tarde ou noite</returns>
        static string BomDia (string saudacao) {

            int hora = DateTime.Now.Hour;

            if (hora <= 11 && hora >= 6) {
                saudacao = "Bom dia!";
            } else if (hora >= 12 && hora <= 18) {
                saudacao = "Boa tarde!";
            } else {
                saudacao = "Boa noite!";
            }
            return saudacao;
        }

        /// <summary>
        /// Retorna um número - teste de sobrecarga
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>número passado como parâmetro</returns>
        static int BomDia (int numero) {
            return numero;
        }

        /// <summary>
        /// função que retorna data e hora atuais
        /// </summary>
        static void ImprimirDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour.ToString ());
        }

        /// <summary>
        /// função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">vetor com valores</param>
        /// <returns>média dos valores</returns>
        static double CalculaMedia (double[] valores) {

            double resultado = 0;
            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }
            resultado = resultado / valores.Length;

            return resultado;
        }
    }
}