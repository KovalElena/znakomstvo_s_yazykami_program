// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстаяние между ними в 3D пространстве.

Console.WriteLine("Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());


double result = DistanceFromCoordinates(x1, y1, z1, x2, y2, z2);
double resultRound = Math.Round(result, 2);
Console.WriteLine($"Расстояние между двумя точками {resultRound}");

double DistanceFromCoordinates(int ax, int ay, int az, int bx, int by, int bz)
{
    double d = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az));
    return d;
}