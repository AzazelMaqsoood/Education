using System;

namespace ArrayTask11
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int x = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 5);
                Console.Write("{0} ", array[i]);
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == x)
                {
                    Console.Write("- {0} ", i+1);
                }
            }

        }
    }
}
