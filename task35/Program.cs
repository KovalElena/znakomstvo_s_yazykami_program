// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

int[] CreateFillArray(int size, int min, int max)
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

int CountTwoDig(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) count += 1;
    }
    return count;
}

int[] array = CreateFillArray(10, 0, 100);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");

int countTwoDig = CountTwoDig(array);
Console.WriteLine($" -> {countTwoDig}");
