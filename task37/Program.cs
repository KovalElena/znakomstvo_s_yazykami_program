// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

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

int[] MultiplyElement(int[] arr)
{
    int newLength = arr.Length / 2;
    if (arr.Length % 2 == 1) newLength += 1;
    int[] newArr = new int[newLength];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArr[newLength - 1] = arr[arr.Length / 2];
    return newArr;
}

int[] array = CreateFillArray(7, 0, 10);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");

int[] array2 = MultiplyElement(array);
Console.Write("[");
PrintArray(array2, ";");
Console.WriteLine("]");