// Напишите программу, которая принимает на вход число (N) и 
// выдает таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

SqrTable(num);

void SqrTable(int n)
{
    int count = 1;
    while (count <= n) ;
    {
        Console.WriteLine($"{count} -> {count * count}");
        count++;
    }
}

