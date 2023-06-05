// Напишите программу, которая принимает на вход два числа (А и В) и 
// возводит число А в натуральную степень В.

Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число В, в степень которого необходимо возвести число А");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB >= 1)
{
    double aToThePowerOfb = AToThePowerOfB(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {aToThePowerOfb}");
}
else
{
    Console.WriteLine("Введено неверное число В");
}
double AToThePowerOfB(int num1, int num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}
