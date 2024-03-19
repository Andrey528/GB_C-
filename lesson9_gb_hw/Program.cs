Console.WriteLine($"Задайте значение N. Напишите программу, которая выведет все натуральные " +
    "числа в промежутке от N до 1. Выполнить с помощью рекурсии");

int n;

Console.WriteLine($"Задайте значение N");
int.TryParse(Console.ReadLine()!, out n);

void nat_numbers(int number)
{
    Console.Write($"{number}, ");
    if (number == 1) return;
    else nat_numbers(number - 1);
}

nat_numbers(n);
Console.WriteLine();

//-------------------------------------------------------------------------------------

Console.WriteLine($"Задайте значения M и N. Напишите программу, которая найдёт сумму " +
    $"натуральных элементов в промежутке от M до N.");

int left_border, right_border;

Console.WriteLine($"Задайте значение левой границы");
int.TryParse(Console.ReadLine()!, out left_border);
Console.WriteLine($"Задайте значение правой границы");
int.TryParse(Console.ReadLine()!, out right_border);

int print_numbers_in_borders(int left_border, int right_border)
{
    if (left_border == right_border)
    {
        return left_border;
    }
    else if (right_border > left_border)
    {
        return left_border + right_border + print_numbers_in_borders(++left_border, --right_border);
    }
    else return 0;
}

Console.WriteLine($"Сумма = {print_numbers_in_borders(left_border, right_border)}");

//-----------------------------------------------------------------------------------

Console.WriteLine($"Напишите программу вычисления функции Аккермана с помощью рекурсии. " +
    $"Даны два неотрицательных числа m и n.");

int funcAckerman(int m, int n)
{
    if (m > 0 && n == 0)
        return funcAckerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return funcAckerman(m - 1, funcAckerman(m, n - 1));
    else return n + 1;
}

int first_number, second_number;

Console.WriteLine($"Задайте значение m для функции Аккермана");
int.TryParse(Console.ReadLine()!, out first_number);
Console.WriteLine($"Задайте значение n для функции Аккермана");
int.TryParse(Console.ReadLine()!, out second_number);

Console.WriteLine($"Функция Аккермана от m = {first_number} и n = {second_number} " +
    $"равна {funcAckerman(first_number, second_number)}");