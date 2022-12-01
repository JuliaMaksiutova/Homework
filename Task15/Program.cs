// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if(dayNumber > 0 && dayNumber < 6)
{
    Console.WriteLine("Этот день не является выходным");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}