// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] massiv = new int[8];
int[] funkcMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}
int[] res = funkcMass(massiv);

for (int i = 0; i < res.Length; i++)
{
    Console.Write($"{res[i]}, ");
}

