using System;

namespace ArrayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            n = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                x--;
                array[i] = x+n;
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
