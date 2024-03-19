Console.WriteLine($"Задайте двумерный массив размером m×n, заполненный " +
    $"случайными вещественными числами.");

int m, n;

Console.Write($"ВВедите m: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"ВВедите n: ");
int.TryParse(Console.ReadLine()!, out n);

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-100, 100) / 10.0;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Напишите программу, которая на вход принимает позиции " +
    $"элемента в двумерном массиве, и возвращает значение этого элемента или " +
    $"же указание, что такого элемента нет.");

double user_elem;
bool user_flag = false;

Console.Write($"ВВедите позицию элемента через пробел: ");
string[] user_position = Console.ReadLine()!.Split(' ');

if (user_position.Length == 2)
{
    int.TryParse(user_position[0], out m);
    int.TryParse(user_position[1], out n);
    if ((m > array.GetLength(0)) || (n > array.GetLength(1)))
        Console.WriteLine($"На такой позиции элемента нет");
    else Console.WriteLine($"Значение элемента {array[m, n]}");
}
else Console.WriteLine($"Некорректный ввод");

Console.Write($"ВВедите значение элемента: ");
double.TryParse(Console.ReadLine()!, out user_elem);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == user_elem)
        {
            Console.Write($"Позиция элемента {user_elem} m = {i}, n = {j}");
            user_flag = true;
        }
    }
}

if (user_flag == false) Console.WriteLine($"Элемент не найден");

//------------------------------------------------------------------

using System;
using System.Runtime.Intrinsics.X86;

Console.WriteLine($"Задайте двумерный массив из целых чисел. Найдите среднее " +
    $"арифметическое элементов в каждом столбце.");

int row_count, col_count;

Console.Write($"ВВедите row_count: ");
int.TryParse(Console.ReadLine()!, out row_count);
Console.Write($"ВВедите col_count: ");
int.TryParse(Console.ReadLine()!, out col_count);

int[,] new_array = new int[row_count, col_count];
double[] avg_array = new double[col_count];

for (int i = 0; i < row_count; i++)
{
    for (int j = 0; j < col_count; j++)
    {
        new_array[i, j] = new Random().Next(10);
        Console.Write($"{new_array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < col_count; i++)
{
    double avg = 0;

    for (int j = 0; j < row_count; j++)
    {
        avg += new_array[j, i];
    }

    avg_array[i] = avg / row_count;
}

var str = string.Join(" ", avg_array);
Console.WriteLine(str);