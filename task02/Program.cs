// Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Большее число {numberA}, меньшее {numberB}");
}
else
{
    Console.WriteLine($"Большее число {numberB}, меньшее {numberA}");
}