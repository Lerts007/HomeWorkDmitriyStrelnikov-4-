using System;
namespace Task_2
{
    public class MatrixWorker
    {
        int[,] matrix;
        int matrixRow;
        int matrixCol;
        public MatrixWorker(int row, int col)
        {
            matrixRow = row;
            matrixCol = col;

            matrix = new int[row, col];
        }
        public void SetElemetByIndex(int value, int row, int col)
        {
            matrix[row, col] = value;
        }

        public void Print()
        {
            for (int i = 0; i < matrixRow; i++)
            {
                for (int j = 0; j < matrixCol; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();

            }
        }
    }
}