// Найти максимальное из трех чисел

Console.Write("Введите чесло А:");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите чесло B:");
int numberB = int.Parse(Console.ReadLine());

Console.Write("Введите чесло C:");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (max < numberB)
    {
    max = numberB;
    }
if (max < numberC)
    {
    max = numberC;
    } 

Console.Write("Max= ");
Console.WriteLine(max);

