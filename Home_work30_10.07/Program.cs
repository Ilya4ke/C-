// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30       4 5 6 7 8

Console.Write("Введите значение M - ");
int m = Convert.ToInt32(Console.ReadLine()); //x
Console.Write("Введите значение N - ");
int n = Convert.ToInt32(Console.ReadLine()); //y
int z = 0;
void Summa(int x, int y, int sum)
{
    sum = sum + y;
    if (x >= y)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    Summa(x, y-1, sum);
}
Summa(m,n,z);


