//// ЗАДАЧА 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int FindMidNum(int number)
{
    int average = 0;
    average = number % 100;
    average = average / 10;
    return average;
}

Console.Write("Input three-digit number ");
int usernum = Convert.ToInt32(Console.ReadLine());

while(usernum < 99 || usernum > 1000)
{
    Console.Write("Your number is not three digits. Try again ");
    usernum = Convert.ToInt32(Console.ReadLine());
}

int middle = FindMidNum(usernum);
Console.WriteLine($"The middle digit of {usernum} is {middle}");
*/

//// ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int FindThirDig(int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    int result = number % 10;
    return result;
}

Console.Write("Input a number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

if(usernum <  100)
{
    Console.WriteLine("Your number is missing the third digit");
}
else
{
    int thirddigit = FindThirDig(usernum);
    Console.WriteLine($"The third digit from {usernum} is {thirddigit}");
}

*/

////  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool WeekendOrNot(int day)
{
    if(day == 6 || day == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Monday    -> 1");
Console.WriteLine("Tuesday   -> 2");
Console.WriteLine("Wednesday -> 3");
Console.WriteLine("Thursday  -> 4");
Console.WriteLine("Friday    -> 5");
Console.WriteLine("Saturday  -> 6");
Console.WriteLine("Sunday    -> 7");
Console.Write("Input a number corresponding to the day of the week: ");
int userday = Convert.ToInt32(Console.ReadLine());

if(userday > 7 || userday < 1)
{
    Console.WriteLine("Your number does not match the day of the week. Try again.");
}
else
{
    int re
}