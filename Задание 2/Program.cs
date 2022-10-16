// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second Number ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine($"Larger {a}, Smaller {b}");
else
    Console.WriteLine($"Larger {b}, Smaller {a}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second Number ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third Number ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max < b)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("Max = " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Input number ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine("even integer");
else
    Console.WriteLine("odd integer");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.WriteLine("Input number ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -1;

N = (N % 2 == 1)
{
   
    N = N - 1;
}
while (N <= i)

i++;
Console.WriteLine(N);
*/

Console.WriteLine("Input number ");
int N =  Convert.ToInt32(Console.ReadLine());
int i = 1;
int k = 1;
while (true)
{
    if (N % 2 == 0)
    {
        Console.Write(N + " ");
    }
    if (k < N)
    {
        break;
    }
    i++;
}


