// Напишите программу, которая принимает на вход число (N) и 
// выдает таблицу кубов чисел от 1 до N.


Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

CubeTable(n);

void CubeTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,3 } -> {i * i * i, 4}");
        i++;
    }
}