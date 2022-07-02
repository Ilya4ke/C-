﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введите размер массива - ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int [x];
Console.Write($"Массив - [ ");
int sum = 0;
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(-20,21);
    Console.Write($"{array[i]} ");
    if (i % 2 == 0)
    {
        sum = sum + array[i];
    }
}
Console.Write($"]");
Console.Write($"\nСумма элементов стоящих на нечетных позициях = {sum}");

