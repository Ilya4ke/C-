// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write ("Введите первое число - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число - ");
int numberB = int.Parse(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine("Первое число кратно второму.");
}
else
{
    Console.WriteLine(numberA % numberB);
}