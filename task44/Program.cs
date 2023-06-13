// Не используя рекурсию,
// выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
int[] CreateArrayFibonacci(int size, int first, int second)
{
    int[] array = new int[size];
    array[0] = first;
    array[1] = second;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

int[] array = CreateArrayFibonacci(10, 0, 1);
PrintArray(array);
