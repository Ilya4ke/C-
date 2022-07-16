// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число M - "); // x
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N - "); // y
int n = Convert.ToInt32(Console.ReadLine());
int res = FunkAkkerman(m,n);
Console.Write($"Результат равен - {res}");

int FunkAkkerman(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else if (y == 0)
    {
        return FunkAkkerman(x - 1, 1);
    }
    else
    {
        return FunkAkkerman(x-1, FunkAkkerman(x, y-1));
    }
}

