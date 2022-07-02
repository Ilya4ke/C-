// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// 8%2 = 0 - делится без остатка, 8 четное число.

Console.Write($"Введите размер массива - ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int [x];
Console.Write($"Массив - [ ");
int sum = 0;
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write ($"{array[i]} ");
    if (array[i] % 2 == 0)
    {
        sum++;
    }
}
Console.Write($"]");
Console.Write($"\nКолличество четных чисел в массиве - {sum}");