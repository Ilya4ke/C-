// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// через функцию
int Compare(string[] NumbersArray)
{
    int sum = 0;
    for (int i = 0; i < NumbersArray.Length; i++)
    {
        if (Convert.ToInt32(NumbersArray[i]) > 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.Write("Введите числа - ");
string numbers = Convert.ToString(Console.ReadLine());
string[] NumbersArr = numbers.Split(",");
Console.Write($"{Compare(NumbersArr)} чисел больше 0");

// int sum = 0;
// // for (int i = 0; i < NumbersArr.Length; i++)
// // {
// //     if (Convert.ToInt32(NumbersArr[i]) > 0)
// //     {
// //         sum++;
// //     }
// // }
// // Console.Write($"{sum} чисел больше 0");