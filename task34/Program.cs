// Задайте массив, заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] % 2 == 0) count = count + 1; 
    }
    return count;
}


int[] array = CreateArrayRndInt(5, 100, 999);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");

int countEvenNumbers = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве - {countEvenNumbers}");