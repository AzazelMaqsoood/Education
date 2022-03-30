using System;

namespace MatrixTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int[,] matrix2 = new int[5, 5];
            int max = 0;
            int i_max = 0;
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 9);
                    if (j % 5 == 0)
                        Console.WriteLine();
                    Console.Write(matrix[i, j] + " [{0},{1}] ", i, j);
                    if (matrix[i,j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == max)
                    {
                        for (int n = 0; n < 4; n++)
                        {
                            if (n % 5 == 0)
                                Console.WriteLine();
                            Console.Write(matrix[i, n] + " [{0},{1}] ", i, n);
                        }
                    }
                }
            }


        }
    }
}
