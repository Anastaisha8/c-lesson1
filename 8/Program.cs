using System;
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
bool not = true;
while (i<=N)
{
    if (i%2 == 0)
    {
        Console.Write(i + ",");
        not = false;

    }
    i++;
}
if (not)
{
    Console.WriteLine("Четных чисел нет");
}