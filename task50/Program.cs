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

// int ElemValue(int numA, int numB)
// {
//     if (numA < 0 || numB < 0)
//     {
//         Console.WriteLine("Позиции элемента не могут быть отрицательными");
//     }
//     else if (numA > matrix.GetLength(0) || numB > matrix.GetLength(1))
//     {
//         Console.WriteLine("Такого элемента нет");
//     }
//     else
//     {
//         Console.WriteLine($"Элемент на позиции ({numA, numB}) имеет значение {matrix[i, j]}");
//     }
// }

int ElemValue(int[,] matrix, int row, int column)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (row > matrix.GetLength(0) || column > matrix.GetLength(1))
            {
                Console.WriteLine("Такого элемента нет");
            }
            else
            {
                Console.WriteLine($"Элемент имеет значение {matrix[i, j]}");
            }
        }
    }
}


int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите позицию элемента  в строке: ");
int Row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента  в столбце: ");
int Column = Convert.ToInt32(Console.ReadLine());

int elemValue = ElemValue(array2d, Row, Column);




