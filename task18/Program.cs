﻿// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();

string range = Range(quarter);
string result = range == null
                ? "Неверно введен номер четверти"
                : $"Диапазон координат для указанной четверти  {range}";
Console.WriteLine(result);

string Range(string q)
{
    if (q == "1") return "x > 0 and y > 0";
    if (q == "2") return "x < 0 and y > 0";
    if (q == "3") return "x < 0 and y < 0";
    if (q == "4") return "x > 0 and y < 0";
    return null;
}
