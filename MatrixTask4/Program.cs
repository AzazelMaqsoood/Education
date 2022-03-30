using System;

namespace MatrixTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int sum = 0;
            int max = 0;
            int j_max = 0;
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 5 == 0)
                        Console.WriteLine();
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write(matrix[i, j] + " [{0},{1}] ", i, j);
                    sum += matrix[i, j];
                    if (sum > max)
                    {
                        max = sum;
                        j_max = j;
                    }
                    if (j == 4)
                    {
                        sum = 0;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(max);

            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write(matrix[k, j_max] + " [{0},{1}] ", k, j_max);
            }
        }
    }
}
