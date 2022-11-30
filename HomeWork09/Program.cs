// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        ShowNumbers(n - 1);
    }
}


ShowNumbers(10);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNumbers(int m, int n)
{
    if (m > n)
    {
        return SumNumbers(m - 1, n) + m;
    }
    else
    {
        if (m < n) return SumNumbers(m, n - 1) + n;
    }
    return n;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());


int res = SumNumbers(num1, num2);
Console.WriteLine(res);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(num1, num2);
Console.Write(result);
*/