﻿// Напишите программу, которая 
// 1. выводит случайное чило из отрезка [10,99]
// и 
// 2. показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
//    Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else
//    Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}



