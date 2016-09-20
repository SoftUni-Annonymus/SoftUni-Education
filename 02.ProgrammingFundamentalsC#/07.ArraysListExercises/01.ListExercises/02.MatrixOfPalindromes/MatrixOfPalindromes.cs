using System;
using System.Collections.Generic;
using System.Linq;
class MatrixOfPalindromes
{
    static void Main()
    {
        var dimension = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var rows = dimension[0];
        var cols = dimension[1];
        var letter = 'a';
        for (int i = 0; i < rows; i++)
        {            
            var middleLetter = letter;
            for (int j = 0; j < cols; j++)
            {
                Console.Write(""+letter+middleLetter+letter+" ");
                middleLetter++;
            }
            letter++;
            Console.WriteLine();
        }
    }
}