// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.Write("Введите координату x первой точки:");
int x1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y первой точки:");
int y1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату z первой точки:");
int z1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату x второй точки:");
int x2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y второй точки:");
int y2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату z второй точки:");
int z2 = int.Parse(Console.ReadLine());

double distance(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double result = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((c2 - c1), 2));
    return result;
}

double distanceResult = distance(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Раастояние между точками A({0},{1},{2}); B({3},{4},{5})= " + distanceResult);