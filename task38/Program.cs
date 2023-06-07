// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double[] CreateArrayRndIntDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, digit);
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