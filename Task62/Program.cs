// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int n = 4;
int[,] arr = FillArraySpiral(n, n);
PrintArray(arr);

int[,] FillArraySpiral(int row, int col)
{
    int count = 1;
    int[,] array = new int[row, col];
    int i = 0, j = 0;
    while (count <= row * col)
    {
        array[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < col - 1)
            j++;
        else if (i < j && i + j >= row - 1)
            i++;
        else if (i >= j && i + j > col - 1)
            j--;
        else
            i--;
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
            Console.Write($"{array[i, j]:d2} ");
        }
        Console.WriteLine();
    }
}