using System;

namespace aula6.cnpj {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Validação de CNPJ\nDigite seu CNPJ: ");
            string cnpj = Console.ReadLine ();

            Console.WriteLine ();
            // 14.572.457.0001-85
        }

        static bool ValidaCNPJ (double[] cnpjUsuario) {
            bool resultado;
            int[] v1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] v2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int calculo = 0;
            int resto = 0;
            int digitoVerificador = 0;
            int digitoVerificador2 = 0;
            int calculoDV2 = 0;
            int resto2 = 0;
            string cnpjNumero = "";

            //calculo do dígito verificador parte I
            //pega os 12 primeiros números do cnpj
             cnpjNumero = cnpjUsuario.Substring (0, 12);

            //soma da multiplicação dos números do cnpj com os definidos no vetor
            for (int i = 0; i <= 11; i++) {
                calculo += int.Parse (cnpjNumero[i].ToString ()) * v1[i];
            }
            //pega o dígito verificador
            resto = calculo % 11;

            if (resto == 0 || resto == 1) {
                digitoVerificador = 0;
            } else {
                digitoVerificador = resto - 11;
            }

            //digito verificador II
            int cnpjNumero2 = cnpjUsuario.ToString (0, 13);

            calculoDV2 += int.Parse (cnpjNumero2[i]) * v2[i];

            resto2 = calculoDV2 % 11;
            if (resto2 == 0 || resto2 == 1) {
                digitoVerificador2 = 0;
            } else {
                digitoVerificador2 = resto2 - 11;
            }

            //transforma em string os digitos verificadores
            digitoVerificador.ToString ();
            digitoVerificador2.ToString ();

            if (digitoVerificador == cnpjUsuario[12].ToString()) {
                resultado = true;
            }

            if (digitoVerificador2 == cnpjUsuario[13].ToString()) {
                resultado = true;
            }

            return resultado;
        }
    }
}