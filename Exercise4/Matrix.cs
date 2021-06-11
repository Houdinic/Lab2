using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Matrix
    {
         public static string[,] GetMatrix()
        {
            Console.WriteLine("Enter the size of your Matrix using 2 Integers");
            string[] dimension=Console.ReadLine().Split(" ");
            int rows = Convert.ToInt32(dimension[0]);
            int cols = Convert.ToInt32(dimension[1]);
            string[,] matrix= new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("Please enter your {0} row",i+1);
                string[] row= Console.ReadLine().Split(" ");
                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            return matrix;
        }
    }
}
