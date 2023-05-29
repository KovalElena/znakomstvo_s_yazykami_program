// Напишите программу, которая выводит случайное трехзначное число из
// удаляет вторую цифру этого числа.


int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}

int number = new Random().Next(100, 1000);

Console.WriteLine($"трехзначное число - {number}");
int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"Число без второй цифры - {deleteSecondDigit}");
