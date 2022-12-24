/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


void FindChillDay(string num)
{

int number; 

int.TryParse(num, out number);
    while (number < 1 || number > 7)
    {
        Console.WriteLine("Неверный ввод. Введите цифру от 1 до 7, обозначающую номер недели: ");
        num = Console.ReadLine() ?? "0";
        int.TryParse(num, out number);  
 
    }
   
    if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)  {
        Console.WriteLine("нет");
    }

    if (number == 6 || number == 7)  {
        Console.WriteLine("да");
    }

    
}


Console.WriteLine("Введите цифру от 1 до 7, обозначающую номер недели: ");
string num = Console.ReadLine() ?? "0";
FindChillDay(num);
