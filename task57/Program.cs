// Составить частотный словарь элементов двумерного массиваю
// Частотный словарь содержит информацию от том, 
// сколько раз встречается элемент входных данных.

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

//  перевели двумерный массив в одномерный
int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

void CountFrequencies(int[] array)
{
    int currentNumber = array[0];
    int count = 1;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($" число {currentNumber} встречается {count} раз");
            currentNumber = array[i];
            count = 1;
        }
    }
    Console.WriteLine($" число {currentNumber} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
int[] array = MatrixToArray(array2d);
Array.Sort(array);

PrintMatrix(array2d);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
CountFrequencies(array);

