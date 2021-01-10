using System;
using System.Globalization;

namespace processamento_dados_casting3 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b;
            double resultado;
            a = 5;
            b = 2;
            resultado = (double)a / b;
            Console.WriteLine(resultado);
        }
    }
}
