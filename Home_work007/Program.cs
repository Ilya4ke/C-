// Удалить вторую цифру трёхзначного числа
Console.Write ("Введите трехзначное число - ");
int numberA = int.Parse(Console.ReadLine());

int numberB = (numberA / 100);
int numberC = ((numberA / 10) % 10);
int numberD = (numberA % 10);

Console.Write(numberB);
Console.Write(numberD);

