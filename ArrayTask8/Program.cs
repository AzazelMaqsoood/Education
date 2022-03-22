using System;

namespace ArrayTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 0;
            int odd = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            int[] array = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(a, b);
                Console.WriteLine("{0} ", array[i]);
                if (array[i] % 2 != 1)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("Четных: {0}", even);
            Console.WriteLine("Нечетных: {0}", odd);
        }
    }
}
