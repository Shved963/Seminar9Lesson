// Задача 65:
// Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

using static Common.Helper;
Console.Clear();
int beginNum = Common.Helper.IntoInt();
int endNum = Common.Helper.IntoInt();
GetNumbersBetween(beginNum, endNum);


void GetNumbersBetween( int num1, int num2)
{
    if ( num1 <= num2)
    {
        Console.Write($"{num1} ");
        GetNumbersBetween(++num1, num2);
    }
    //GetNumbersBetween(num, ++i);
    return;
}

