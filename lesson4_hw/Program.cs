Console.WriteLine($"Напишите цикл, который принимает на вход два числа (A и B) и " +
    $"возводит число A в натуральную степень B.");

Console.Write($"Введите A и B через пробел: ");
string[] numbers = Console.ReadLine()!.Split(" ");
int[] numbers_to_int = new int[numbers.Length];

if (numbers.Length > 2)
{
    Console.WriteLine($"Чисел больше двух");
}
else
{
    for (int i = 0; i < numbers.Length; i++)
        int.TryParse(numbers[i], out numbers_to_int[i]);

    Console.WriteLine($"{Math.Pow(numbers_to_int[0], numbers_to_int[1])}");
}

//---------------------------------------------------------------------------

Console.WriteLine($"Напишите программу, которая принимает на вход число" +
    $" и выдаёт сумму цифр в числе.");

Console.Write($"Введите число: ");
string number = Console.ReadLine()!;
int sum = 0;

for (int i = 0; i < number.Length; i++)
    sum += (int)Char.GetNumericValue(number[i]);

Console.WriteLine($"Сумма чисел: {sum}");

//---------------------------------------------------------------------------

Console.WriteLine($"Напишите программу, которая задаёт массив из 8 элементов" +
    $" и выводит их на экран.");

int[] array = new int[8];

for ( int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(100);
    Console.Write(array[i] + " ");
}