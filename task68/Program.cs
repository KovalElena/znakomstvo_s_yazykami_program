// Напишите программу 
// вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите натуральное число M ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0) 
{
Console.WriteLine($"Введенное число не должно быть отрицательным");
}
else AkkermanFunction(numberM, numberN);

Console.WriteLine($"A(m,n) =  {AkkermanFunction(numberM, numberN)}");

int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num2 == 0) return AkkermanFunction(num1 - 1, 1);
    else return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
}