using System;
using System.Globalization;

namespace Processamento_dados_casting2 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;

            area = (b1 + b2) / 2.0 * h;
            Console.WriteLine(area);
        }
    }
}
