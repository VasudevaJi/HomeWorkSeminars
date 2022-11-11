//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            current++;
    return current;
}   

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n);
ShowArray(myArray);

Console.WriteLine($"There are {EvenNumbers(myArray)} even numbers in the created array");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99999, 100000);
    }
    return array;
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumEvenPos(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n);
ShowArray(myArray);

Console.WriteLine($"The sum of the numbers in odd positions is {SumEvenPos(myArray)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(-99999, 100000), 4);
    }
    return array;
}   

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}


double DiffMinAndMax(double[] array)
{
    double max = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > max)
            max = array[i];

    double min = max;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < min)
            min = array[i];

    double result = max - min;
    
    return result;
}


Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(n);
ShowArray(myArray);

Console.WriteLine($"The difference between the maximum and minimum number in the array is " + Math.Round(DiffMinAndMax(myArray), 4));
*/
