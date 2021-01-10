using System;

namespace estrutura_matrizes {
    class Program {
        static void Main(string[] args) {

            int M, N, i, j;

            Console.WriteLine("Quantas linhas vai ter a matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas colunas vai ter a matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    Console.WriteLine("Elemento[" + i + "," + j + "] ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA:");
            for (i = 0; i < M; i++) {
                for (j = 0; j < N; j++) {
                    Console.WriteLine(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
