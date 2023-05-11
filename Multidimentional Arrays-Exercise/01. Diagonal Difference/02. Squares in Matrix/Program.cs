using System;
using System.Linq;

namespace SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = line[col];
                }
            }

            int counter = 0;

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i,j] == matrix[i, j+1] && 
                        matrix[i+1,j] == matrix[i+1, j+1] && 
                        matrix[i,j] == matrix[i+1, j+1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
