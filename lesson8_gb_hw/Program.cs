//методы для массивов

using System.Xml.Linq;

void print_array(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array2dInit(int m, int n) 
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return array;
}

//решение задач

Console.WriteLine($"Задайте двумерный массив. Напишите программу, которая " +
    $"упорядочит по убыванию элементы каждой строки двумерного массива.");

int m, n;

Console.Write($"ВВедите m: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"ВВедите n: ");
int.TryParse(Console.ReadLine()!, out n);

int[,] array = array2dInit(m, n);

int row_count = array.GetLength(0);
int col_count = array.GetLength(1);

for (int i = 0; i < row_count; i++)
{
    for (int j = 0; j < col_count; j++)
    {
        for (int l = j + 1; l < col_count; l++)
        {
            if (array[i, j] < array[i, l])
                (array[i, j], array[i, l]) = (array[i, l], array[i, j]);
        }
    }
}

Console.WriteLine();
print_array(array);

//-----------------------------------------------------------------------------------

Console.WriteLine($"Задайте прямоугольный двумерный массив. Напишите программу, которая " +
    $"будет находить строку с наименьшей суммой элементов.");

int[,] new_array = array2dInit(4, 5);

int new_row_count = new_array.GetLength(0);
int new_col_count = new_array.GetLength(1);

int min_sum = -1;
int row_pos = 0;

for (int i = 0; i < new_row_count; i++)
{
    int temp = 0;

    for (int j = 0; j < new_col_count; j++)
    {
        temp += new_array[i, j];
    }

    if ((temp < min_sum) || (min_sum == -1))
    {
        min_sum = temp;
        row_pos = i;
    }
}

Console.WriteLine($"Минимальная скмма элементов на сроке с индексом {row_pos}");

//----------------------------------------------------------------------------------

Console.WriteLine($"Задайте две матрицы. Напишите программу, которая будет находить " +
    $"произведение двух матриц.");
//rule col matrix1 = row matrix2
int[,] new_array1 = array2dInit(2, 2);
int[,] new_array2 = array2dInit(2, 2);
int new_matrix_row = new_array1.GetLength(0);
int new_matrix_col = new_array2.GetLength(1);
int dim = new_array1.GetLength(1);
int[,] matrix = new int[new_matrix_row, new_matrix_col];

for (int i = 0; i < new_matrix_row; i++)
{
    for (int j = 0; j < new_matrix_col; j++)
    {
        for (int l = 0; l < dim; l++)
        {
            matrix[i, j] += new_array1[i, l] * new_array2[l, j];
        }
    }
}
print_array(matrix);

//------------------------------------------------------------------------------------

Console.WriteLine($"Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. " +
    $"Напишите программу, которая будет построчно выводить массив, добавляя индексы " +
    $"каждого элемента.");

int firstDim, secondDim, thirdDim;

Console.Write($"ВВедите 1ю размерность: ");
int.TryParse(Console.ReadLine()!, out firstDim);
Console.Write($"ВВедите 2ю размерность: ");
int.TryParse(Console.ReadLine()!, out secondDim);
Console.Write($"ВВедите 3ю размерность: ");
int.TryParse(Console.ReadLine()!, out thirdDim);

int[,,] gMatrix = new int[firstDim, secondDim, thirdDim];

int gSetDim = firstDim * secondDim * thirdDim;

int[] gSet = new int[gSetDim];

Random r = new Random();

int totalCount = 0;

while (totalCount < gSetDim)
{
    int gEl = r.Next(10, 100);
    bool el_flag = true;

    for (int i = 0; i < gSetDim; i++)
    {
        if (gEl == gSet[i])
        {
            el_flag = false;
            break;
        }
    }
    if (el_flag)
    {
        gSet[totalCount] = gEl;
        totalCount++;
    }
}

for (int i = 0; i < gSetDim; i++)
{
    Console.WriteLine($"{gSet[i]} ");
}

Console.WriteLine();

int l = 0;

for (int i = 0; i < firstDim; i++)
{
    for (int j = 0; j < secondDim; j++)
    {
        for (int k = 0; k < thirdDim; k++)
        {
            gMatrix[i, j, k] = gSet[l];
            l++;
        }
    }
}

for (int i = 0; i < firstDim; i++)
{
    for (int j = 0; j < thirdDim; j++)
    {
        for (int k = 0; k < secondDim; k++)
        {
            Console.Write($"{gMatrix[i, k, j]}({i},{k},{j}) ");
        }
        Console.WriteLine();
    }
}

//---------------------------------------------------------------------------------

Console.WriteLine($"Напишите программу, которая заполнит спирально массив 4 на 4.");

int matrixDim = 4;

int[,] spireMatrix = new int[matrixDim, matrixDim];

for (int i = 0; i < matrixDim; i++)
    for (int j = 0; j < matrixDim; j++)
        spireMatrix[i, j] = 0;

//print_array(spireMatrix);
int currentChar = 0;

for (int padding = 0; padding < matrixDim / 2; padding++)
{
    for (int j = padding; j < matrixDim - padding; j++)
    { 
        spireMatrix[padding, j] = currentChar;
        currentChar++;
    }

    for (int i = padding + 1; i < matrixDim - padding - 1; i++)
    { 
        spireMatrix[i, matrixDim - padding - 1] = currentChar;
        currentChar++;
    }

    for (int j = matrixDim - padding - 1; j > padding - 1; j--)
    {
        spireMatrix[matrixDim - padding - 1, j] = currentChar;
        currentChar++;
    }

    for (int i = matrixDim - padding - 2; i > padding; i--)
    { 
        spireMatrix[i, padding] = currentChar;
        currentChar++;
    }
}
print_array(spireMatrix);