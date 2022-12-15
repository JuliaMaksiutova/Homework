// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Вариант с отдельным введением каждого числа
int n;
int counter = 0;
Console.WriteLine("Введите количество чисел");
n = Convert.ToInt16(Console.ReadLine());
int []Numbers = new int[n];
int i = 0;
while (i < n)
{
Console.WriteLine("Введите число");
Numbers[i] = int.Parse(Console.ReadLine());
Console.WriteLine();
i++;
}

for (i = 0; i < n; i++) {
if (Numbers[i] > 0) {
counter++;
}
}

List<int> numList = new List<int>(Numbers);
Console.WriteLine($"{String.Join(",", numList)} -> " + counter);

// Вариант с введением через всех чисел сразу
// Console.WriteLine("Введите числа через пробел");
// string[] numList = Console.ReadLine().Split(new Char[] { ' ' });
// int i;
// int counter = 0;
// int n = numList.Length;

// for (i = 0; i < n; i++) {
// if (int.Parse(numList[i]) > 0) {
// counter++;

// }
// }

// Console.WriteLine($"{String.Join(',',numList)} -> {counter}");



