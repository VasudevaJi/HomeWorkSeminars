// ЗAДАЧА 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

bool Palindrome(int num)
{
    int firstnum = num / 10000;
    int fifthnum = num % 10;

    num /= 10;
    num %= 1000;

    int secondnum = num / 100;
    int fourthnum = num % 10;

    if(firstnum == fifthnum && secondnum == fourthnum)
        return true;
    else
        return false;
}

Console.Write("Input five-digit number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

while(usernum > 99999 || usernum < 10000)
{
    Console.Write("Wrong number! Try again: ");
    usernum = Convert.ToInt32(Console.ReadLine());
}

bool res = Palindrome(usernum);
if(res == true)
    Console.WriteLine($"Your number {usernum} is Palindrome");
else
    Console.WriteLine($"Your number {usernum} is NOT Palindrome");

*/

// ЗАДАЧА 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double Theorem(double numX1, double numY1, double numX2, double numY2, double numZ1, double numZ2)
{
    double rollsFirst = numX1 - numX2;
    rollsFirst = Math.Pow(rollsFirst, 2);
    double rollsSecond = numY1 - numY2;
    rollsSecond = Math.Pow(rollsSecond, 2);
    double rollsThird = numZ1 - numZ2;
    rollsThird =  Math.Pow(rollsThird, 2);

    double hypotenus = rollsFirst + rollsSecond + rollsThird; 
    hypotenus = Math.Sqrt(hypotenus);
    return hypotenus;
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Theorem(x1, y1, x2, y2, z1, z2);
Console.WriteLine("hypotenuse is " + result);

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.






