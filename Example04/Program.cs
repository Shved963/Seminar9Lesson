// Задача 69:
// Напишите программу, которая на вход
// принимает два числа A и B,
// и возводит число А в целую степень B
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8


using static Common.Helper;
using System.Diagnostics;
Console.Clear();

int num = Common.Helper.IntoInt();
int degree = Common.Helper.IntoInt();

double result = 0;

Stopwatch watch = new Stopwatch();
watch.Start();
//Thread.Sleep(1000);
for (int i = 0; i< 1000000; i++)
{
    result = GetExponentiation(num, degree);
}
watch.Stop();

Console.WriteLine(watch.ElapsedMilliseconds);
Console.WriteLine(result);


double GetExponentiation(int num1, int num2, int i = 0)
{
    
    if (i == num2)
    {
        return 1;
    }
    

    return num1 * GetExponentiation(num1, num2, ++i);

}

