// Напишите программу, которая принимает на вход число и
// выдает количство цифр в числе.

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int digitsInNumber = DigitsInNumber(number);

Console.WriteLine($"{number} содержит {digitsInNumber} цифр(ы)");

int DigitsInNumber(int num)
{
    int digits = 0;

    if (num == 0) return 1;

    while (num != 0)
    {
        digits++;
        num /= 10;
    }
    return digits;
}



