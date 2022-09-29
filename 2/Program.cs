using System;
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    int max= number1;
    int min= number2;
    Console.WriteLine($"Максимальное число = {max}");
    Console.WriteLine($"Минимальное число = {min}");
   
}
if (number1<number2)
{ 
    int max = number2;
    int min = number1;
    Console.WriteLine($"Максимальное число = {max}");
    Console.WriteLine($"Минимальное число = {min}");

}
if (number1 == number2)
{
    Console.WriteLine("Введенные числа равны.");
}
