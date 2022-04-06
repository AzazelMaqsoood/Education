using System;

namespace SortTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int c = 0; c < arr.GetLength(0); c++)
            {
                for (int j = 0; j < arr.GetLength(0)-1; j++)
                {
                    if (j < N / 2)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            int temp = arr[j];
                            temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                    else
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }

            foreach (int r in arr)
            {
                Console.WriteLine(r);
            }
        }
    }
}
