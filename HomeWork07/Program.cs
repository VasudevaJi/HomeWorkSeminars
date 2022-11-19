// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

/*
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] =  Math.Round(new Random().NextDouble() + new Random().Next(-10, 11), 4);

    return array;
}


 void Show2dArray(double[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
 }


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


 void Show2dArray(int[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
 }

void FindIndex(int[,] array, int i, int j)
{
    if(i > array.GetLength(0) || j > array.GetLength(1))
        Console.WriteLine("Array does not have this index");
    else
        Console.WriteLine(array[i,j]);
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.Write("Input a string search: ");
int rowsSearch = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a columns search: ");
int colSearch = Convert.ToInt32(Console.ReadLine());

FindIndex(myArray, rowsSearch, colSearch);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1, 10);

    return array;
}


 void Show2dArray(int[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "  ");
        
        Console.WriteLine();
    }
 }


double[] MeanOfColumns(int[,] array)
 {
    double[] resArray = new double [array.GetLength(1)]; 
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sumColumn = 0;
        for(int j = 0; j < array.GetLength(0); j++)
            sumColumn += array[j,i];
        resArray[i] = Math.Round(sumColumn / array.GetLength(1), 3);
    }
    return resArray;
 }

 void ShowArray(double[] array)
 {
    for(int i = 0; i < array.GetLength(0); i++)
    {
            Console.Write(array[i] + "  ");
        
    }
 }



Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);

Console.WriteLine(" ");
double[] resultArray = MeanOfColumns(myArray);
Console.WriteLine("Arithmetic mean of each column:");
ShowArray(resultArray);
*/


