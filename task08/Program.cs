// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
    Console.WriteLine("Некорректный ввод");
else
{
    int i = 2;
    while (i <= number)
    {
        if (i % 2 == 0)
            Console.Write($"{i} ");
        ++i;
    }
}
