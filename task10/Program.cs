// Напишите программу, которая принимает на вход трехзначное число и 
// на выходе показывает вторую цифру этого числа.

int ShowSecondDigit(int num)
{
    int secondDigit = (num / 10) % 10;
    return secondDigit;
}


Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());


if (number >= 100 && number <= 999)
{
    int showSecondDigit = ShowSecondDigit(number);
    Console.WriteLine($"Вторая цифра трехзначного числа {showSecondDigit}");
}
else
{
    Console.WriteLine("Неверный ввод");
}

