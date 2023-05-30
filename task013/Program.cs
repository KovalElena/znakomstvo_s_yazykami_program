// Напишите программу, которая выводит третью цифру заданного числа,
// или сообщает, что третьей цифры нет.

int ReturnThirdDigit(int num)
{
    int thirdDigit = (num % 10);
    return thirdDigit;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999) number /= 10;
{
    if (number < 999 && number > 100)
    {
        int returnThirdDigit = ReturnThirdDigit(number);
        Console.WriteLine($"Третья цифра числа {returnThirdDigit}");
    }

    else
    {
        Console.WriteLine("Третьей цифры в числе нет");
    }
}
// if (number < 999)
// {
//     int returnThirdDigit = ReturnThirdDigit(number);
//     Console.WriteLine($"Третья цифра числа {returnThirdDigit}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры в числе нет");
// }






