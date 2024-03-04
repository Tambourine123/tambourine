using System;
class MatrixAddition
{
    static void Main()
    {
        Console.Write("Enter the number of rows (N): ");
        int numRows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns (M): ");
        int numCols = int.Parse(Console.ReadLine());

        int[,] matrixA = InputMatrix("Matrix A", numRows, numCols);

        int[,] matrixB = InputMatrix("Matrix B", numRows, numCols);

        int[,] resultMatrix = AddMatrices(matrixA, matrixB, numRows, numCols);

        Console.WriteLine("Resultant Matrix (A + B):");
        PrintMatrix(resultMatrix, numRows, numCols);
    }

    static int[,] InputMatrix(string matrixName, int numRows, int numCols)
    {
        Console.WriteLine($"Enter values for {matrixName} ({numRows} by {numCols} matrix):");
        int[,] matrix = new int[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write($"Enter element at position ({i + 1}, {j + 1}): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }
    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB, int numRows, int numCols)
    {
        int[,] resultMatrix = new int[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(int[,] matrix, int numRows, int numCols)
    {
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
