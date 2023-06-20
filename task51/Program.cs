// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1,1) и т.д.)

int GetDiagonSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}

// int SumElementsMainDiagonal (int[,] arr)
// {
//     int min = Math.Min(arr.GetLength(0), arr.GetLength(1));
//     int sum = 0;
//     for (int i = 0; i < min; i++)     
//     {
//       sum +=arr[i,j];  
//     }
//     return sum;
// }

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

int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("Сумма элементов на главной диагонали -> " + GetDiagonSum(array2d));