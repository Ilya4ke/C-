// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями.
// Значения b1, k1, b2 и k2 задаются пользователем.
// y = k1 * x + b1, y = k2 * x + b2; k1 и k2 угловые коэффициенты ; b1 и b2 эти коэфициенты совпадают то прямые лежат друг на друге
// y = a  * x + c,  y = b  * x + d;  a и b угловые коэффициенты ; с и d эти коэфициенты совпадают то прямые лежат друг на друге
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число k1 - ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2 - ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1 - ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 - ");
double d = Convert.ToDouble(Console.ReadLine());

double[] Formula(double a, double b, double c, double d)
{
  double x = 0;
  double y = 0;

  if (a != b && c != d)
  {
    x = (d - c) / (a - b);
    y = (d - c) / (a - b) * a + c;
  }

  else
  {
    Console.WriteLine("Прямые не пересекаются или совпадают");
  }
  return new double[] {x, y};
}

double[] point = Formula(a, b, c, d);

Console.WriteLine($"Координаты точки пересечения ({point[0]},{point[1]})");