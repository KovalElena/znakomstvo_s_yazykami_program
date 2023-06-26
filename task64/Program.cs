// Задайте значение N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) 
{
Console.WriteLine($"Введенное число не должно быть отрицательным");
}
else NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if ( num == 0) return;
    if (num > 0) Console.Write($"{num} ");
    NaturalNumbers (num - 1);
}

