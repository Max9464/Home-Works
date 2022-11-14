//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreateRandommArray(int size) 
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)

        array[i] = new Random().Next(100, 1000);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}

int EvenSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) 
    sum ++ ;

return sum;

}

Console.Write("Input of elements: ");
int n = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandommArray(n);
ShowArray(myArray);

int evenSum = EvenSum(myArray);
Console.WriteLine($"Even sum is :" + evenSum);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreateRandom(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 1000);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            sum += array[i];
    return sum;
}

Console.WriteLine("Input elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandom(n);

ShowArray(myArray);

int evenSum = EvenSum(myArray);
Console.WriteLine("Sum of even is: " + evenSum);
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

int[] CreateRandom(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 1000);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Max(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
        if (max < array[i])
            max = array[i];
    return max;

}

int Min(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
        if (min > array[i])
            min = array[i];
    return min;
}

Console.WriteLine("Input elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandom(n);

ShowArray(myArray);

int max = Max(myArray);
int min = Min(myArray);
int result = max - min;
Console.WriteLine("Max - Min = : " + result);





