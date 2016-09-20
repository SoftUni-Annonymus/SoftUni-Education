using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var count = 0;
        if (dimension.Length < 2)
        {
            Console.WriteLine(0);
        }
        else
        {
            int rows = dimension[0];
            int cols = dimension[1];

            var matrix = new char[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            }
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col] && matrix[row][col] == matrix[row + 1][col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }        
    }
}