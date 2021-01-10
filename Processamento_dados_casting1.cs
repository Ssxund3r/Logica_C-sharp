using System;
using System.Globalization;

namespace Processamento_dados_casting1 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x;
            double y;

            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y.ToString("F1", CI));
        }
    }
}
