// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write ("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());

if (daynumber < 6)
{
    Console.Write("Это рабочий день -");

    if (daynumber==1)
    {
        Console.Write(" Понедельник");
    }
    else if (daynumber==2)
    {
        Console.Write(" Вторник");
    }
    else if (daynumber==3)
    {
        Console.Write(" Среда");
    }
    else if (daynumber==4)
    {
        Console.Write(" Четврег");
    }
    else if (daynumber==5)
    {
        Console.Write(" Пятница");
    }
}
else 
{    
    Console.Write("Ура это выходной!!!");

    if (daynumber==6)
    {
        Console.Write(" Суббота");
    }
    else if (daynumber==7)
    {
        Console.Write(" Воскресенье");
    }
}