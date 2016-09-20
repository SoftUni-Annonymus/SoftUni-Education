using System;
using System.Linq;
class RotateAndSum
{
    static void Main()
    {
        var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = int.Parse(Console.ReadLine());
        int[] sumOfElements = new int[arr.Length];

        RotateSum(arr, n, sumOfElements);

        Console.WriteLine(string.Join(" ", sumOfElements));
    }

    private static void RotateSum(int[] arr, int n, int[] sumOfElements)
    {
        for (int i = 0; i < n; i++)
        {
            int lastElement = arr[arr.Length - 1];

            Array.Copy(arr, 0, arr, 1, arr.Length - 1);
            //for (int j = arr.Length - 1; j > 0; j--)
            //{
            //    arr[j] = arr[j - 1];
            //}

            arr[0] = lastElement;

            for (int k = 0; k < arr.Length; k++)
            {
                sumOfElements[k] += arr[k];
            }
        }
    }
}

