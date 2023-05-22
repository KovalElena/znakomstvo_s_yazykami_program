// Напишите программу, которая на вход принимает2 числа и проверяет, 
// является ли первое число квадратом второго.

Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine($"Да, число {numberA} является квадратом числа {numberB}");
}
else
{
    Console.WriteLine($"Нет, число {numberA} не является квадратом числа {numberB}");
}