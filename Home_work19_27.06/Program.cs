// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write($"Введите размер массива - ");
int x = Convert.ToInt32(Console.ReadLine());
int [] array = new int [x];
int max =0;
int min = int.MaxValue; // int.MaxValue - максимальное значение которое может принимать int
Console.Write($"Массив - [");
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(-11,11);
    Console.Write($"{array[i]} ");
    
    if (max <= array[i])
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.Write($"]");
Console.Write($"\nМаксимальное число - {max} ");
Console.Write($"\nМинимальное число - {min} ");
Console.Write($"\nРазница между максимальным и минимальным = {max - min}");