using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 4, 6, 1, 12, 45, 0 };

            //int max = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}

            //Console.WriteLine(max);


            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            //int sum = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    sum = sum + arr[i, i];
            //}
            //Console.WriteLine(sum);


            //int res = arr[0, 1] + arr[1, 0];

            //Console.WriteLine(res);


            int[] arr = { 45, 34, 21, 0, 56, 22 };


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
