// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число - ");
int number = Convert.ToInt32 (Console.ReadLine());
string arr = number.ToString();

if(arr.Length<6 && arr.Length>4)
{
    if (arr[0]==arr[4] && arr[1]==arr[3])
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не является палиндром");
    }
}
else
{
    Console.WriteLine("Число не соответствует условию");
}