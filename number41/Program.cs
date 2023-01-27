/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество чисел ");
int count = int.Parse(Console.ReadLine());
int countItog = 0;

for (int i = 1; i <= count; i++)
{
    Console.WriteLine($"Введите {i}-е число: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        countItog += 1;
    }
}

Console.WriteLine($"Чисел больше нуля: {countItog}");