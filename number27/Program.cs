/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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


int a = GetNumber("Введите число");

    int result = 0;
    while (a != 0)
    {
        result += a % 10;
        a /= 10;
    }
    Console.WriteLine($"Сумма числа = {result}"); 
  

  










            