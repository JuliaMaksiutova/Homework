// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество солбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m, n];
int[,] array2 = new int[m, n];
int[,] productArray = new int[m, n];

void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MatrixMultiply(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            productArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                productArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    PrintArray(productArray);
}

FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine(" ");
MatrixMultiply(array1, array2);