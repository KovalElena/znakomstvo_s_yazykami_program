// Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine);

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++);
    {
        sum = sum + i; // sum += 1
    }
    return sum;
}