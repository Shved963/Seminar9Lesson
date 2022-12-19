// Задача 67:
// Напишите программу, которая будет
// принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12 45 -> 9

using static Common.Helper;

Console.Clear();

int num = Common.Helper.IntoInt();

Console.WriteLine(GetSum(num));

int GetSum(int num)
{
    if (num == 0)
    {
        return 0;
    }
        int sum =num % 10;
        num = num/10;
        return sum + GetSum(num);
    
}