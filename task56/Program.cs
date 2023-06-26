// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int Sum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i} равна {sum}");
    }
    return 0;
}

void RowSumMinimum(int[,] matrix)
{
    int minimalRow = Sum(matrix);
    int indexMinimalRow = 0;
    temp = Sum(matrix);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (temp < minimalRow)
            {
                minimalRow = temp;
                indexMinimalRow = i;
            }
            Console.WriteLine($"Строка с наименьшей суммой элементов {indexMinimalRow}");
            else
            {
                
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Sum(array2d);
RowSumMinimum(array2d);


