// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ElementPosition(int[,] array)
{
    Console.Write("Введите номер строки искомого элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца искомого элемента: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row > array.GetLength(0)
        || row - 1 < 0
        || column > array.GetLength(1)
        || column - 1 < 0)
    { Console.WriteLine("В массиве нет такого числа"); }
    else
    { Console.WriteLine($"Ваше число: {array[row - 1, column - 1]}"); }
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillArray(m, n);
PrintArray(arr);
ElementPosition(arr);