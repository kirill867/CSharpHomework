/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

void FindMiddle(string num)
{

int number; 

int.TryParse(num, out number);
    while (number < 100 || number > 999)
    {
        Console.WriteLine("Неверный ввод. Введите число от 100 до 999: ");
        num = Console.ReadLine() ?? "0";
        int.TryParse(num, out number);  

    }
   
    int middle = number / 10 % 10;

    Console.WriteLine($"Вторая цифра числа {number} - {middle}");
}


Console.WriteLine("Введите число от 100 до 999: ");
string num = Console.ReadLine() ?? "0";
FindMiddle(num);
