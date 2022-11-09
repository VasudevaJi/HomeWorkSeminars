//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponentiation(int numa, int numb)
{
    int result = numa;
    for(int current = 1; current != numb; current++)
    result *= numa;
    return result;
}

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int print = Exponentiation(a, b);

Console.WriteLine($"Number {a} to the power of {b} is equal to {print}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int Sum(int number)
{
    int sum = 0;
    int a = number % 10;
    sum += a;
    while(number > 0)
    {
        number /= 10;
        a = number % 10;
        sum += a;
    }
    return sum;
}

Console.Write("Input a number: ");
int usernum = Convert.ToInt32(Console.ReadLine());
int result = Sum(usernum);

Console.WriteLine($"The sum of the digits in the number is {result}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.





