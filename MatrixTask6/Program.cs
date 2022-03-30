using System;

namespace MatrixTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    if (j-i>0)
                    {
                        matrix[i, j] = 0;
                    }
                    if (j % 5 == 0)
                        Console.WriteLine();
                    Console.Write(matrix[i, j] + " [{0},{1}] ", i, j);
                }
            }

        }
    }
}
