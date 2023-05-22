// Напишите программу, которая принимает на вход трехзначное число, 
// а на выходе показывает последнюю цифру этого числа.

Console.Write("Введите целое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int LastDigit = number % 10;
    Console.WriteLine($"{LastDigit} является последней цифрой числа {number}");
}
else
{
    Console.WriteLine("Неверное число");
}