// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second Number ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine($"Max = {a}, Min = {b}");
else
    Console.WriteLine($"Max = {b}, Min = {a}");