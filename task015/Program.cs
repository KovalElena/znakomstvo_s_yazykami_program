// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.

bool VacationDayNumber(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    bool result = VacationDayNumber(number);
    Console.WriteLine(result ? "Выходной" : "Будний");
}
else
{
    Console.WriteLine("Неверный ввод");
}