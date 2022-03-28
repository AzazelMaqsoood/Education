using System;

namespace MatrixTask3
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            Random rnd = new Random();
            float max = 0;
            float min = 0.1f;
            float i_min = 0;
            float j_min = 0;
            float i_max = 0;
            float j_max = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 5 == 0)
                        Console.WriteLine();
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write(matrix[i, j] + " [{0},{1}] ", i,j);
                    if (matrix[i, j] > max)
                    { 
                        max = matrix[i, j];
                        i_max = i;
                        j_max = j;
                    }
                    if (matrix[i, j] <= min && min !=0)
                    {
                        min = matrix[i, j];
                        i_min = i;
                        j_min = j;
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("Индексы мин. значения: {0} {1}", i_min, j_min);
            Console.WriteLine("Индексы макс. значения: {0} {1}", i_max, j_max);
            Console.WriteLine(max+" "+min);
        }
    }
}
