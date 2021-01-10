using System;
using System.Globalization;

namespace processamento_dados_casting4 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double a;
            int b;
            a = 5.0;
            b = (int) a;

            Console.WriteLine(b);
        }
    }
}
