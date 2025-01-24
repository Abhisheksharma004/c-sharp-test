using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class arrays
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            // Accessing elements
            Console.WriteLine("Element at row 1, col 2: " + matrix[1, 2]);  // Output: 6

            // Traversing the 2D array using for loop
            Console.WriteLine("Matrix elements:");
            for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) -> rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) -> columns
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
