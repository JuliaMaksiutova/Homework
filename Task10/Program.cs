﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);

if(a>99 && a<1000)
{
int a2 = a % 100 / 10;
Console.WriteLine($"вторая цифра трёхзначного числа {a2}");
}
else 
{
Console.WriteLine("введенное число не трёхзначное");
}