// Показать вторую цифру трёхзначного числа

Console.Write ("Введите трехзначное число - ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine((numberA / 10) % 10);
