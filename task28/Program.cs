// Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 0)
{
    Console.WriteLine("Введено неверное число");
    return;
}

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равна {factorial}");

int Factorial(int num)
{
    int result = 1;
    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
