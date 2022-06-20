// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату X1 первой точки - ");
double X1 = double.Parse (Console.ReadLine());
Console.Write("Введите координату Y1 первой точки - ");
double Y1 = double.Parse (Console.ReadLine());
Console.Write("Введите координату Z1 первой точки - ");
double Z1 = double.Parse (Console.ReadLine());

Console.Write("Введите координату X2 второй точки - ");
double X2 = double.Parse (Console.ReadLine());
Console.Write("Введите координату Y2 второй точки - ");
double Y2 = double.Parse (Console.ReadLine());
Console.Write("Введите координату Z2 второй точки - ");
double Z2 = double.Parse (Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2)+ Math.Pow(Z2-Z1, 2));
Console.Write ($"Расстояние между первой и второй точкой = {distance}");