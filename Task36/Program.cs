// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOFOddNumbers(int[] a)   
{
    int sum = 0;
    for (int i = 0; i <a.Length; i += 2)
    {
        sum = sum + a[i];
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = arrRand(size, 0, 1000);  
arrPrint(arr);                        
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {SumOFOddNumbers(arr)}");