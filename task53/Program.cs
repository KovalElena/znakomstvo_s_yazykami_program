// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

void ReverseRows(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[firstRow, i];
        arr[firstRow, i] = arr[lastRow, i];
        arr[lastRow, i] = temp;
    }

}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
ReverseRows(array2d);
PrintMatrix(array2d);