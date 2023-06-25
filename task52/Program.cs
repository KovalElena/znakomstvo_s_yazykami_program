// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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

int AverageOfEveryColumn(int[,] matrix)
{
    double sum = 0;
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = ; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j]; 
        }
        Console.Write($"Среднее арифметическое столбца {j} равно {sum / matrix.GetLength(0):F1} ");  
    }
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);

AverageOfEveryColumn(array2d);




