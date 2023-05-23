// Напишите программу, которая принимает  на вход число и выдает,
// является ли число четным.

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine(&"Число {number} является четным");
}
else
{
    Console.WriteLine(&"Число {number} не является четным");
}
