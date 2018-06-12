using System;

namespace Upper_Triangular_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            UpperTriangularMatrix();
        }

        private static void UpperTriangularMatrix()
        {
            Console.WriteLine("Please enter the number of rows and columns for the matrix:");
            var numberOfRows = int.Parse(Console.ReadLine());
            var numberOfColumns = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the square matrix:");
            int[,] matrix = new int[numberOfRows, numberOfColumns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe entered matrix is as follows:");
            DisplayTheMatrix(matrix);

            if (matrix.GetLength(0)==1 && matrix.GetLength(1)==1)
            {
                matrix[numberOfRows-1, numberOfColumns-1] = 0;
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (i != 0)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }

            Console.WriteLine("\nThe upper triangular matrix is as follows:");
            DisplayTheMatrix(matrix);

            Console.ReadLine();
        }

        private static void DisplayTheMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
