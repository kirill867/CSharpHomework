/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
         Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
            else
        {
        Console.WriteLine("ввели не число");
        }
    }

    return result;
}

int GetDegree(int a, int b)
{
    int result = a;


    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }


    return result;
}

int a = GetNumber("Введите число a");
int b = GetNumber("Введите число b");
int result = GetDegree(a, b);

Console.WriteLine($"Число {a} в степени {b} = {result}");