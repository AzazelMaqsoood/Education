using System;

namespace MatrixTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int sum = 0;
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                    sum += matrix[i,j];
                }
            }
            Console.WriteLine("Сумма элементов: ", sum);
        }
    }
}
