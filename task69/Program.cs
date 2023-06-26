// Напишите программу, которая 
// на вход принимает два числа А и В,
// и возводит число А в целую степень В 
// с помощью рекурсии.

Console.WriteLine("Введите натуральное число A ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"число {numberA} в степени {numberB}   = {Exponentiation(numberA, numberB)}");

int Exponentiation(int num, int exp)
{
if (exp == 0) return 1;
return num * Exponentiation(num, exp - 1);
}

// int Exponentiation1(int num, int exp)
// {
// return exp == 0 ? 1 : num * Exponentiation(num, exp - 1);
// return num * Exponentiation(num, exp - 1);
// }

