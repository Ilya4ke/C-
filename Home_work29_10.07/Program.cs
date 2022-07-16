// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Задайте значение N - ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"--> {N} ");
void y(int x)
{
    x = x - 1;
    if (x == 0)
    {
        return;
    }
    Console.Write($"{x} ");
    y(x);
}
y(N);