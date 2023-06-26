// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите натуральное число M ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N ");
int numberN = Convert.ToInt32(Console.ReadLine());

ConsecutiveNumbersInRange(numberM, numberN);
void ConsecutiveNumbersInRange(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1}, ");
        ConsecutiveNumbersInRange(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1}, ");
        ConsecutiveNumbersInRange(num1 - 1, num2);
    }
    else
    {
        Console.Write($"{num1} ");
    }
}