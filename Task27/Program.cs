// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int A)
{
    int sum = 0;
    A = Math.Abs(A);
    while (A > 0)
    {
        sum = sum + A%10;
        A = A / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int sum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма цифр числа {sum} равна {Sum(sum)}");