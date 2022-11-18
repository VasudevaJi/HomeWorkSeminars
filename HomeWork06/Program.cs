// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int[] InputArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}


Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = InputArray(m);
ShowArray(myArray);

int result = PositiveNumbers(myArray);
Console.WriteLine($"Number of positive numbers is {result}");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.Write("Input a k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

if(k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"intersection point is {Math.Round(x, 4)}; {Math.Round(y, 4)}");
}
else
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Lines are coincide");
    else    
        Console.WriteLine("Lines are parallel");
*/