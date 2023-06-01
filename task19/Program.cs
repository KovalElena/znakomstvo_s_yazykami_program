// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool isPalindromicNumber = IsPalindromicNumber(number);
    Console.WriteLine(isPalindromicNumber ? $"Число {number} является палиндромом" 
    : $"Число {number} не является палиндромом");
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}

bool IsPalindromicNumber(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = (num / 1000) % 10;
    int fourthDigit = (num / 10) % 10;
    int fifthDigit = num % 10;
    return firstDigit == fifthDigit && secondDigit == fourthDigit;
}


// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 9999 && number < 100000)
// {
//     int firstDigit = number / 10000;
//     int secondDigit = (number / 1000) % 10;
//     int fourthDigit = (number / 10) % 10;
//     int fifthDigit = number % 10;
//     if (firstDigit == fifthDigit && secondDigit == fourthDigit)
//     {
//         Console.WriteLine($"Число {number} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }

