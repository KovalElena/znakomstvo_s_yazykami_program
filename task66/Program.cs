// Задайте значения M и N.
// Напишите программу, которая
// найдет сумму натуральных элементов в промежутке от M до N 
// с помощью рекурсии.

Console.WriteLine("Введите натуральное число M ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма  чисел от M до N: ");
Console.WriteLine(SumNatural(numberM, numberN));

int SumNatural(int num1, int num2)
{
    if (num1 == 0 && num2 == 0) return 0;
    if (num1 == num2) return num1;
    if (num1 < num2) return num1 + SumNatural(num1 + 1, num2);
    else return num1 + SumNatural(num1 - 1, num2);
}



