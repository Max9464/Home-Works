// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*int Num(int a, int b)
{
    int current = 1;
    int num = a;
    while ( current != b)
    {
        num = num * a;
        current++;
    }
    
    return num;

}
Console.Write("Input firts number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Num(a, b));
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.WriteLine("Input a number: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("Sum is: " + sum);
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array= new int[8] {1,5,9,8,7,9,1,3};

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}

