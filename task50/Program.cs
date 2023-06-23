// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
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

bool IsElemExists(int[,] matrix, int row, int column)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (row >= 0 && row <= matrix.GetLength(0) && column >= 0 && column <= matrix.GetLength(1))
                return true;
        }
    }
    return false;
}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите позицию элемента  в строке: ");
int Row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента  в столбце: ");
int Column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsElemExists(array2d, Row, Column) ? $"Элемент имеет значение {array2d[Row, Column]}" : "Такого элемента нет");




