using System;
using System.Collections.Generic;
using System.Linq;

class DiagonalDifference
{
    static void Main()
    {
        var matrixSize = int.Parse(Console.ReadLine());
        var matrix = new int[matrixSize][];
        
        for (int row = 0; row < matrixSize; row++)
        {
            matrix[row]= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
        var primaryDiagonal = 0;
        var secondDiagonal = 0;
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                if (row==col)
                {
                    primaryDiagonal +=matrix[row][col];
                }
                if (col==matrixSize-row-1)
                {
                    secondDiagonal += matrix[row][col];
                }
            }
        }
        Console.WriteLine(Math.Abs(primaryDiagonal-secondDiagonal));
    }
}