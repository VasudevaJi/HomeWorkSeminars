// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}


void DescendingSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int size = array.GetLength(1);
        for (int k = 0; k < size; k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
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
Console.WriteLine(" ");

DescendingSort(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] FindSumRows(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sums[i] = sum;
    }
    return sums;
}

int[] FindMinSum(int[] array)
{
    int[] minSum = new int[2];
    int min = array[0];
    int minRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            minRow = i;
        }
    }
    minSum[0] = min;
    minSum[1] = minRow;
    return minSum;
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
Console.WriteLine(" ");

int[] rowsSums = FindSumRows(myArray);
ShowArray(rowsSums);
Console.WriteLine(" ");

int[] minRow = FindMinSum(rowsSums);

Console.WriteLine($"The row with the minimum amount is: {minRow[1]} ({minRow[0]})");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}



int[,] MultiMatrices(int[,] array1, int[,] array2)

{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    int mult = 0;

    for (int i = 0; i < array2.GetLength(1); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                mult = 0;
                for (int l = 0; l < array1.GetLength(1); l++)
                {
                    mult += array1[k, l] * array2[l, i];
                }
                result[k, i] = mult;
            }
        }
    }
    return result;
}



Console.Write("Input a number of rows: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateRandom2dArray(m1, n1, min1, max1);
Show2dArray(myArray1);
Console.WriteLine(" ");

Console.WriteLine("Input the initial data of the second matrix: ");

Console.WriteLine($"The number of rows will be equal to the number of columns of the first matrix! ({n1})");
int m2 = n1;
Console.WriteLine(" ");
Console.Write("Input a number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray2 = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(myArray2);
Console.WriteLine(" ");

int[,] ResArray = MultiMatrices(myArray1, myArray2);
Show2dArray(ResArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально двумерный массив 

/*
int[,] CreateSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int count = 1;
    int max = rows * columns;

    int rMin = 0, rMax = rows - 1;
    int cMin = 0, cMax = columns - 1;

    while (count <= max)
    {
        for (int i = cMin; count <= max && i <= cMax; i++)
        {
            array[rMin, i] = count++;
        }
        rMin++;
        for (int i = rMin; count <= max && i <= rMax; i++)
        {
            array[i, cMax] = count++;
        }
        cMax--;
        for (int i = cMax; count <= max && i >= cMin; i--)
        {
            array[rMax, i] = count++;
        }
        rMax--;
        for (int i = rMax; count <= max && i >= rMin; i--)
        {
            array[i, cMin] = count++;
        }
        cMin++;
    }

    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiralArray(m, n);
Show2dArray(myArray);
*/