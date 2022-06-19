// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write ("Введите число - ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

//Решение через массив
if (number < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{ 
    string numberA = number.ToString();
    Console.WriteLine(numberA[2]);
}

// if (number < 100)
// {
//     Console.WriteLine ("Третьей цифры нет");
// }
// else
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//   Console.WriteLine(number % 10);
// } 


