// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// вводим координаты первой точки
Console.Write("Введите координаты точки A(x1, y1, z1) х1 - ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A(x1, y1, z1) y1 - ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки С(x1, y1, z1) z1 - ");
int z1 = int.Parse(Console.ReadLine());

// // вводим координаты второй точки
Console.Write("Введите координаты точки B(x2, y2, z2) х2 - ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B(x2, y2, z2) y2 - ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B(x2, y2, z2) z2 - ");
int z2 = int.Parse(Console.ReadLine());

// находим расстояние между точками

double distance = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));

Console.WriteLine($"Расстояние между точками в 3D пространстве = {distance:f2}");