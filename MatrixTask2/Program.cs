using System;

namespace MatrixTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];
            int k = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                    if (matrix[i, j] == k)
                        cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
