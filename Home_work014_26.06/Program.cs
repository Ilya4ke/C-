// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B\

// 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

Console.Write("Введите число А - ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В - ");
int B = Convert.ToInt32(Console.ReadLine());
// int res = 1;
// int count = 0;

// Через цикл WHILE
// while(count<=B-1){
//     res = A*res;
//     count++;
// }
// Console.WriteLine($"Число А в степени В = {res}");

// Через цикл FOR
// for(int count = 0; count<=B-1; count++){
//     res = res*A;
// }
// Console.WriteLine($"Число А в степени В = {res}");

// Через цикл Функцию
int stepen (int A){
    int res = 1;
    for (int count = 0; count<=B-1; count++){
        res = res * A;
    }
    return res;
}
Console.WriteLine($"Число А в степени В = {stepen(A)}");