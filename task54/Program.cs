// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    // 0      1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] DescendingSort(int[,] matrix)
{
    int temp = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) -1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine("По убыванию: ");
DescendingSort(array2d);
PrintMatrix(array2d);