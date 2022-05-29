// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int numberA = new Random ().Next(10,100); 
Console.WriteLine(numberA);   
int numberB = (numberA % 10); 
int numberC = (numberA / 10); 

int max = numberB;

if (numberC > max)
    {
        max = numberC;
        Console.WriteLine(max);
    }   
else
{
    Console.WriteLine(max);
}