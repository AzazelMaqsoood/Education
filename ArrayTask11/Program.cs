using System;

namespace ArrayTask11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int x = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int equalCnt = 0;

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 5);
                Console.WriteLine("{0} ",array[i]);
                if (array[i] == x)
                    equalCnt++;
            }
            Console.WriteLine(equalCnt);
        }
    }
}
