using System;

namespace SortTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int r in arr)
                Console.Write(r + " ");
            Console.WriteLine();

            for (int j = 0; j < arr.Length; j++)
            {
                for (int c = 0; c < arr.Length-1-j; c++)
                {
                    if (arr[c] % 10 + arr[c] % 100 + arr[c]/10 + arr[c]/100 < arr[c+1] % 10 + arr[c+1] % 100 + arr[c+1] / 10 + arr[c+1] / 100)
                    {
                        temp = arr[c];
                        arr[c] = arr[c + 1];
                        arr[c + 1] = temp;
                    }
                    foreach (int r in arr)
                        Console.Write(r + " ");
                    Console.WriteLine();
                }
            }
        }
    }
}
