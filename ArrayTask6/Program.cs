using System;

namespace ArrayTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 1];

            for (int i = n; i >= 1; i--)
            {
                array[i] = (int)Math.Pow(2, i);
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
