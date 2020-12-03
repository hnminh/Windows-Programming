using System;

namespace Assignment_1_1
{
    class Program
    {
        private const int MinDimension = 2;
        private const int MaxDimension = 10;

        static int[,] InitializeMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                }
            }

            return matrix;
        }

        static int[,] SumOf2Matricies(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix1.GetLength(1))
            {
                int[,] sumMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
                return sumMatrix;
            }
            else
            {
                return null;
            }
        }

        static int[,] SubOf2Matricies(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix1.GetLength(1))
            {
                int[,] subMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        subMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }
                return subMatrix;
            }
            else
            {
                return null;
            }
        }

        static int[,] MulOf2Matricies(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                int[,] mulMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
                // make sure that all the initial values of result matrix is 0
                for (int i = 0; i < mulMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < mulMatrix.GetLength(1); j++)
                    {
                        mulMatrix[i, j] = 0;
                    }
                }

                // multiplication part
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)  // matrix1.GetLength(1) == matrix2.GetLength(0)
                    {
                        for (int k = 0; k < matrix2.GetLength(1); k++)
                        {
                            mulMatrix[i, k] += matrix1[i, j] * matrix2[j, k];
                        }
                    }
                }

                return mulMatrix;
            }
            else
            {
                return null;
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();

            int row = r.Next(MinDimension, MaxDimension);
            int col = r.Next(MinDimension, MaxDimension);

            int[,] matrix1 = InitializeMatrix(row, col);
            int[,] matrix2 = InitializeMatrix(row, col);

            int[,] sumMatrix = SumOf2Matricies(matrix1, matrix2);
            int[,] subMatrix = SubOf2Matricies(matrix1, matrix2);

            Console.WriteLine("Sum matrix:");
            for (int i = 0; i < sumMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sumMatrix.GetLength(1); j++)
                {
                    Console.Write("{0,6}", sumMatrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Subtraction matrix:");
            for (int i = 0; i < subMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < subMatrix.GetLength(1); j++)
                {
                    Console.Write("{0,6}", subMatrix[i, j]);
                }
                Console.WriteLine();
            }

            // multiplication of 2 matrix m*n and n*p

            int m = r.Next(MinDimension, MaxDimension);
            int n = r.Next(MinDimension, MaxDimension);
            int p = r.Next(MinDimension, MaxDimension);

            matrix1 = InitializeMatrix(m, n);
            matrix2 = InitializeMatrix(n, p);
            int[,] mulMatrix = MulOf2Matricies(matrix1, matrix2);

            Console.WriteLine("Multiplication matrix:");
            for (int i = 0; i < mulMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mulMatrix.GetLength(1); j++)
                {
                    Console.Write("{0,6}", mulMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
