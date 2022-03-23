using System;

namespace ArrayTask9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            int result = int.MinValue;


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n + 1];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(a,b);
                Console.WriteLine("{0} ", array[i]);
                if (array[i] > result)
                {
                    result = array[i];
                }
                else if (result < 0)
                {
                    result = -1;
                }
                
            }
            Console.WriteLine(":{0}", result);
        }
    }
}
