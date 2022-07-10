// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int m = 3;
int n = 4;
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Напишите позицию в строке М - ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите позицию в строке N - ");
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i == y-1)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == x-1)
            {
                Console.Write($"На позиции ({y};{x}) находится число {matrix[i, j]} ");
            }
            else if (x-1 >= matrix.GetLength(1))
            {
                Console.Write("Координаты превышают размер массива ");
                break;
            }
        }
    }
    else if (y-1 >= matrix.GetLength(0))
    {
        Console.Write("Координаты превышают размер массива ");
        break;
    }
}