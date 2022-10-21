// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.






