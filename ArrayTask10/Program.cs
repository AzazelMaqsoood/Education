using System;

namespace ArrayTask10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 1];
            Random rnd = new Random();
            double average = 0;


            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(a, b);
                average += array[i];
                Console.WriteLine("{0} ", array[i]);
            }
            average /= n;
            Console.WriteLine("Среднее арифметическое: {0}", average);
        }
    }
}
