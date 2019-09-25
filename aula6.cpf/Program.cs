using System;

namespace aula6.cpf {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Digite o CPF: ");
            string cpf = Console.ReadLine ();

            Console.WriteLine (ValidaCPF (cpf));
        }

        /// <summary>
        /// Função para validar o CPF
        /// </summary>
        /// <param name="cpfusuario">CPF do usuário</param>
        /// <returns>Se cpf é valido ou não</returns>
        static bool ValidaCPF (string cpfusuario) {
            int[] v1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            bool resultado = false;
            string cpfCalculo = "";
            int resto = 0;
            int calculo = 0;
            string digitoV1 = "";
            string digitoV2 = "";

            // cpfusuario = cpfusuario.Trim (".");
            // cpfusuario = cpfusuario.Trim ("-");

            cpfCalculo = cpfusuario.Substring (0, 9);

            for (int i = 0; i <= 8; i++) {
                calculo += int.Parse (cpfCalculo[i].ToString ()) * v1[i];
            }
            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 9) {
                digitoV1 = "0";
            } else {
                digitoV1 = calculo.ToString ();
            }

            if (digitoV1 == cpfusuario[9].ToString ()) {
                resultado = true;
            }

            int[] v2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            resto = 0;
            cpfCalculo = cpfCalculo + calculo.ToString ();
            calculo = 0;

            for (int i = 0; i <= 9; i++) {
                calculo += int.Parse (cpfCalculo[i].ToString ()) * v2[i];
            }
            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 9) {
                digitoV2 = "0";
            } else {
                digitoV2 = calculo.ToString ();
            }

            if (digitoV2 == cpfusuario[10].ToString ()) {
                resultado = true;
            }

            return resultado;
        }
    }
}