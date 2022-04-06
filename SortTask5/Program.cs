using System;
using System.Linq;

namespace SortTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            //заполянем массив случайными числами
            var rnd = new Random();

            int mediana = 0;

            var arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(10);

            var sum = 0;
            foreach (int r in arr)
            {
                Console.Write(r+ " ");
                sum += r;
            }

            
                //перебираем элементы, пока не достигнем 50% от суммы:
                var accum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    accum += arr[i];
                    if (accum >= sum / 2)
                    {
                    mediana = i;
                    break;
                    }   
                }
            
            Console.WriteLine();
            Console.WriteLine(mediana);


            Console.ReadKey();
        }
    }
}

