using System;
using System.Globalization;

namespace Estrutura_if_else {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int hora;
            Console.WriteLine("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if ( hora < 12) {
                Console.WriteLine("bom dia! ");
            }
            else {
                Console.WriteLine("Boa tarde! ");
            }
        }
    }
}
