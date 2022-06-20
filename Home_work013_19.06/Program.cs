// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());
int X = 1;

while(X<=N)
{
    int numbers = X*X*X;
    Console.Write($" {numbers}");
    X++;
}