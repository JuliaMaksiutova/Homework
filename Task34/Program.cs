// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arrRand(int size, int minValue, int maxValue)
{
    int[] a = new int[size];
    for (int i=0; i < size; i++)
    {
        a[i] = new Random().Next(minValue, maxValue+1); 
    }
    return a;
}

void arrPrint(int[] a)     
{
    Console.WriteLine($"[{String.Join(", ", a)}]");
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = arrRand(size, 0, 1000); 
arrPrint(arr);
int count = 0;
foreach (var a in arr)
{
    if (a%2 == 0) count++;
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}");
