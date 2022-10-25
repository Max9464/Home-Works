bool Pol(int number)
{
    int a = number % 10;
    int b = (number % 100) * 10 + a;
    int c = (number % 1000) * 100 + b;
    int d = (number % 10000) * 1000 + c;
    int f = (number % 100000) * 10000 + d;
    
        if (number == f)
     {
        return true;
     }
    
        else
     {
         return false;
     }
    
}

//int num = new Random().Next(10000, 1000000);
Console.Write("Number ");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{num}");
bool result = Pol(num);

    if(result == true)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

