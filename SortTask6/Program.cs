using System;

namespace SortTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            Random rnd = new Random();
            int temp = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = rnd.Next(1, 10);
                Console.Write(arr[i] + " ");

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i]%2==0 && arr[j]%2==0 && arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();

            foreach (int r in arr)
            {
                Console.Write(r+" ");
            }

        }
    }
}
