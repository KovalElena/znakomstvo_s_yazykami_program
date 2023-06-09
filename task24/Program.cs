﻿// Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 0)
{
    Console.WriteLine("Введено неверное число");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 1;
    for (int i = 2; i <= num; i++)
    {
        sum = sum + i; // sum += i
    }
    return sum;
}