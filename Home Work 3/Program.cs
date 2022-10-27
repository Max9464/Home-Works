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

Console.Write("Number ");
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
