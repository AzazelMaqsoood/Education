using System;

namespace ArrayTask14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            int max = 0;
            int min = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-10, 10);
                if (array[i] > max && array[i]%2 == 0 && array[i] > 0)
                {
                    max = array[i];
                }
                else if (array[i] < min && array[i] % 2 == 0 && array[i] > 0)
                {
                    min = array[i];
                }
                Console.Write("{0}", array[i]);
                Console.WriteLine();
            }
            Console.WriteLine("max: {0} , min: {1}", max, min);
        }
    }
}
