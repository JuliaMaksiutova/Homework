﻿// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int a1 = a / 10000;
int a5 = a % 10;
int a2 = a % 10000 / 1000;
int a4 = a % 100 / 10;

if ((a1 == a5) && (a2 == a4))
{
    Console.WriteLine("Число является палиндромом");
}
else if ((a / 10000 < 1) || (a / 10000 > 9))
{
    Console.WriteLine("Введено не пятизначное число");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}