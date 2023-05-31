// Напишите программу, которая 
// на вход принимает координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = DistanceFromCoordinates(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);

double DistanceFromCoordinates(int ax, int ay, int bx, int by)
{
    double sumCathetus = (bx - ax) * (bx - ax) + (by - ay) * (by - ay);
    double d = Math.Sqrt(sumCathetus);
    return d;
}