// Задача 69:
// Напишите программу, которая на вход
// принимает два числа A и B,
// и возводит число А в целую степень B
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8


using static Common.Helper;

Console.Clear();

int num = Common.Helper.IntoInt();
int degree = Common.Helper.IntoInt();

Console.WriteLine(GetExponentiation(num, degree));


int GetExponentiation(int num1, int num2, int i = 0)
{
    if (i == num2)
    {
        return 1;
    }

    return num1 * GetExponentiation(num1, num2, ++i);

}

