// Задайте массив вещественных чисел. 
// Найдите разницу между максимальными и минимальными элементами массива.

double[] CreateArrayRndDouble(int size, int min, int max, int round)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double DifferenceMaxMin(double max, double min)
{
    double dif = max - min;
    return dif;
}

double[] array = CreateArrayRndDouble(5, -10, 10, 2);
Console.Write("[");
PrintArrayDouble(array, ";");
Console.WriteLine("]");

double minElem = MinElem(array);
Console.WriteLine($"Минимальный элемент массива - {minElem}");
double maxElem = MaxElem(array);
Console.WriteLine($"Максимальный элемент массива - {maxElem}");

double differenceMaxMin = DifferenceMaxMin(maxElem, minElem);
Console.WriteLine($"Разность максимального и минимального элементов  - {differenceMaxMin}");