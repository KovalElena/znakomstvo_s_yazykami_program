﻿// Задайте 2 матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

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

int[,] matrix1 = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix1);

int[,] matrix2 = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix2);
