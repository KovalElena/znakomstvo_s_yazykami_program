// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позициях.

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

int SumNumbersOfOddIndexes(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(5, 1, 10);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");

int sumNumbersOfOddIndexes = SumNumbersOfOddIndexes(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позицициях равна {sumNumbersOfOddIndexes}");
