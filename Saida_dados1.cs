using System;
using System.Globalization;

namespace Saida_dados1 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 24;
            salario = 4560.9;
            nome = "Gabriel Costa";
            sexo =  'M';

            Console.WriteLine("O funcionario " + nome + ", sexo " + sexo + ", ganha " + salario.ToString("F2", CI) + " e tem " + idade +  " anos");


        }
    }
}
