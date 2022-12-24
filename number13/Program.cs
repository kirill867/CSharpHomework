/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/



void FindThirdDigit(string num)
{

int number;
int thirdDigit = 0;
int flag = 0;
int.TryParse(num, out number);

int lenght = num.Length;

    while (lenght < 3)
    {
        Console.WriteLine("Третьей цифры нет");
        flag = 1;
        break;       

    }
   
    while (lenght > 3)
    {
        number = number / 10;
        lenght--; 
    }

    if (lenght == 3){
        thirdDigit = number % 10;
    }
   
    if (flag == 0){
        Console.WriteLine($"Третья цифра {num} - {thirdDigit}");
    }
    
}


Console.WriteLine("Введите число от 100: ");
string num = Console.ReadLine() ?? "0";
FindThirdDigit(num);




