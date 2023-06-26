// Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.



// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n-1);
// }
// Console.WriteLine(FactorialRec(5));

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа:");
Console.WriteLine(SumDigits(number));

int SumDigits(int num)
{
if (num == 0) return 0;
return num % 10 + SumDigits(num/10);
}
