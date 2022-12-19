// Задача 63: Задайте значение N.
// Напишите программу, которая выведет
// все натуральные числа
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using static Common.Helper;
Console.Clear();
int num = Common.Helper.IntoInt();
GetNumbersBetween(num);


void GetNumbersBetween( int num, int i = 1)
{
    if ( i <= num)
    {
        Console.Write($"{i} ");
        GetNumbersBetween(num, ++i);
    }
    //GetNumbersBetween(num, ++i);
    return;
}

