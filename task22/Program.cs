// Напишите программу, которая принимает на вход число (N) и 
// выдает таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());

SquareTable(n);

void SquareTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,3 } -> {i * i, 4}");
        i++;
    }
}

