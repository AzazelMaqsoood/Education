using System;

namespace SortTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int temp = 0;
            bool isChanged = false;
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int r in arr)
                Console.Write(r + " ");
            Console.WriteLine();

            do
            {
                for (int c = 0; c < arr.Length - 1 - j; c++)
                {
                    if (arr[c] < arr[c + 1])
                    {
                        temp = arr[c];
                        arr[c] = arr[c + 1];
                        arr[c + 1] = temp;
                        foreach (int r in arr)
                            Console.Write(r + " ");
                        Console.WriteLine();
                        isChanged = true;
                    }
                }
                j++;

            } while (j< arr.Length && isChanged == true);



        }
    }
}