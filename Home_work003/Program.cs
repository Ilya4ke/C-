// Выяснить является ли число чётным

Console.Write("Введите число: ");
int numberA = int.Parse (Console.ReadLine());

if(numberA % 2 == 0)
{
    Console.Write("Заданное число четное.");
}
else
{
    Console.Write("Заданное число не является четным.");
}