// Напишите программу Замена элементов массива: 
// положительные элементы массива замените на отрицательные,
// и наоборот.

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

void ChangeSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = CreateFillArray(10, -10, 10);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");
ChangeSign(array);
Console.Write("[");
PrintArray(array, ";");
Console.WriteLine("]");