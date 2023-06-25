// Задайте двумерный массив из целых чиселю
// Напишите программу, которая
// удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
                            // 0      1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i,j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i,j], 5}");
        }
       Console.WriteLine();
    }
}

int[,] IndexMinimalElement(int[,] matrix)
{
    int minElement = matrix[0,0];
    int[] result = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < minElement)
            {
                minElement = matrix[i,j];
                result[0] = i;
                result[1] = j;
            }  
        }
       
    }
    return result;
}

int[,] RemoveRowColumn(int[,] matrix)
{
    int rows = matrix.GetLength(0) -1;
    int columns = matrix.GetLength(1) -1;
    int[,] newMatrix = new int[rows,columns];

    int m = 0;
    for (int i = 0; i < rows; i++)
    {
       if (m == matrix[0]) m++;

       int n = 0;
       for (int j = 0; j < columns; j++)
       {
        if (n == matrix[1]) n++;
       newMatrix[i,j] = matrix[m,n];
       n++;
       }
       m++;
    }
    return newMatrix;
}


int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();

int[] indexMinimalElement = IndexMinimalElement(matrix);
int[,] newMatrix = RemoveRowColumn(IAsyncResult, matrix);
PrintMatrix(newMatrix);