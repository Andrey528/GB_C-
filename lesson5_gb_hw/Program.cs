Console.WriteLine($"Пользователь вводит с клавиатуры M чисел. Посчитайте, " +
    $"сколько чисел больше 0 ввёл пользователь.");

Console.WriteLine($"ВВедите числа через пробел");
string[] array_str = Console.ReadLine()!.Split(' ');
int[] array_int = new int[array_str.Length];
int count = 0;

for (int i = 0; i < array_str.Length; i++)
{
    int.TryParse(array_str[i], out array_int[i]);
    if (array_int[i] > 0) count++;
}

Console.WriteLine($"Больше нуля {count}");

//--------------------------------------------------------------------------

Console.WriteLine($"Напишите программу, которая найдёт точку пересечения двух " +
    $"прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; " +
    $"значения b1, k1, b2 и k2 задаются пользователем.");

double k1, k2, b1, b2;

Console.WriteLine($"ВВедите k1");
double.TryParse(Console.ReadLine()!, out k1);
Console.WriteLine($"ВВедите b1");
double.TryParse(Console.ReadLine()!, out b1);
Console.WriteLine($"ВВедите k2");
double.TryParse(Console.ReadLine()!, out k2);
Console.WriteLine($"ВВедите b2");
double.TryParse(Console.ReadLine()!, out b2);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение при x = {x} и y = {y}");