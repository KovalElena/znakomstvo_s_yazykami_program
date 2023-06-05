// Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в числе.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int countDigitsInNumber = CountDigitsInNumber(number);
Console.WriteLine($"Сумма цифр  в числе {number} равна {SumDigitsInNumber(number, index)}");

int CountDigitsInNumber(int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}

int SumDigitsInNumber(int num, int index)
{
    int sum = 0;
    for (int i = 1; i <= index; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
