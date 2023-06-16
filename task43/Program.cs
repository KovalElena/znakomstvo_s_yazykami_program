// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями у = к1*х+в1, у=к2*х+в2. 
// Значения в1, к1, в2, к2 задаются пользователем.


double GetNumber(string prompt)
{
    Console.Write($"Enter {prompt} value: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

void GetIntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("The lines are identical");
            return;
        }

        Console.WriteLine("The lines are parallel");
        return;
    }

    double x = Math.Round((b2 - b1) / (k1 - k2), 1); 
    double y = Math.Round(k1 * x + b1, 1);
    Console.WriteLine($"The intersection point is ({x}, {y})");
}

double b1 = GetNumber("b1");
double k1 = GetNumber("k1");
double b2 = GetNumber("b2");
double k2 = GetNumber("k2");


GetIntersectionPoint(k1, b1, k2, b2);
