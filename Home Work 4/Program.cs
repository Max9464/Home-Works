// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Num(int a, int b)
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
