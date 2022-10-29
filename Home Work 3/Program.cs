//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Pol(int number)
{
    int a = number % 10;
    int b = (number / 10) % 10;
    int c = (number / 100) % 10;
    int d = (number / 1000) % 10;
    int f = number / 10000;
    int result = a * 10000 + b * 1000 + c * 100 + d * 10 + a;

    if (number == result)
    {
        return true;
    }

    else
    {
        return false;
    }

}

Console.Write("Input five's number ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Pol(num);
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");

}
*/

/*
double Range(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
    return distance;
}
Console.WriteLine("input First Point x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Second Point x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z2");
int z2 = Convert.ToInt32(Console.ReadLine());
double lenght = Range(x1, y1, x2, y2, z1, z2);
Console.WriteLine($"Distance between tow points is {Math.Round(lenght, 2)}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Input number ");
double n = Convert.ToInt32(Console.ReadLine());
n = Math.Pow(n, 3);
double result = 0;

for (double i = 1; result <= n; i++)
{
    result = Math.Pow(i, 3);
    Console.Write(result + ", ");
}








