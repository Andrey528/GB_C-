// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

using System.Runtime.Serialization.Formatters;

string number;
int flag = 0;

Console.Write($"Введите число: ");
number = Console.ReadLine()!;

for (int i = 0; i < number.Length / 2; i++)
{
    if (number[i] != number[number.Length - i - 1])
    {
        Console.WriteLine($"{number} -> нет");
        flag = -1;
        break;
    }
}

if (flag == 0) Console.WriteLine($"{number} -> да");

//-------------------------------------------------------------

int Ax, Ay, Az, Bx, By, Bz;

Console.Write($"Введите координату x точки A: ");
int.TryParse(Console.ReadLine()!, out Ax);
Console.Write($"Введите координату y точки A: ");
int.TryParse(Console.ReadLine()!, out Ay);
Console.Write($"Введите координату z точки A: ");
int.TryParse(Console.ReadLine()!, out Az);
Console.Write($"Введите координату x точки B: ");
int.TryParse(Console.ReadLine()!, out Bx);
Console.Write($"Введите координату y точки B: ");
int.TryParse(Console.ReadLine()!, out By);
Console.Write($"Введите координату z точки B: ");
int.TryParse(Console.ReadLine()!, out Bz);

double x = Math.Pow((Bx - Ax), 2);
double y = Math.Pow((By - Ay), 2);
double z = Math.Pow((Bz - Az), 2);
double ans = Math.Round(Math.Sqrt(x + y + z), 2);
Console.WriteLine($"Расстояние между точками A и B = {ans}");

//---------------------------------------------------------------

//Напишите программу, которая принимает на вход число (N) и выдаёт
//таблицу кубов чисел от 1 до N.

int num;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}