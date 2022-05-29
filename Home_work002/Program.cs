// По заданному номеру дня недели вывести его название
//1 == Понедельник
//2 == Вторник
//3 == Среда
//4 == Четверг
//5 == Пятница
//6 == Суббота
//7 == Воскресенье

Console.Write("Введите номер дня недели: ");
int daynumber = int.Parse (Console.ReadLine());
while (daynumber <= 7)
    if (daynumber == 1)
    {
        Console.Write("Понедельник");
    }
    else if (daynumber == 2)
    {
        Console.Write("Вторник");
    }
        else if (daynumber == 3)
    {
        Console.Write("Среда");
    }
        else if (daynumber == 4)
    {
        Console.Write("Четверг");
    }
        else if (daynumber == 5)
    {
        Console.Write("Пятница");
    }
        else if (daynumber == 6)
    {
        Console.Write("Суббота");
    }
        else if (daynumber == 7)
    {
        Console.Write("Воскресенье");
    }
if (daynumber > 7);
{
    Console.Write("В неделе всего 7 дней :)");
}