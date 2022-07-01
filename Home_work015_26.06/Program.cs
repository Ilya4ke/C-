// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число - ");
string arr = Convert.ToString(Console.ReadLine());
// int i = 0;
// int sum = 0;

// Через цикл WHILE
// while(i<arr.Length){
//     sum = sum + Convert.ToInt32(arr [i].ToString());
//     i++;
// }
// Console.WriteLine($"Число А в степени В = {sum}");

// Через цикл FOR
// for(int i = 0; i<arr.Length; i++){
//     sum = sum + Convert.ToInt32(arr [i].ToString());
// }
// Console.WriteLine($"Число А в степени В = {sum}");

// Через цикл Функцию
int funkSum(string arr){
    int sum = 0;
    for(int i = 0; i<arr.Length; i++){
        sum = sum + Convert.ToInt32(arr [i].ToString());
    }
    return sum;
}
Console.WriteLine($"Число А в степени В = {funkSum(arr)}");