
int GetNumberToPow(string message)
{
    int number;
    while (true){
        if ((!int.TryParse(message, out number)))
        {
            Console.WriteLine("Неверный ввод, введите число: ");
            message = Console.ReadLine() ?? "";
        }
        else if (number <= 1)
        {
            Console.WriteLine("Неверный ввод, число должно быть больше единицы: ");
            message = Console.ReadLine() ?? "";           
        }
        else
        {
            break;
        }
    }
    return number;
}


void MakeCube(int number)
{
    Console.Write($"Кубы числа {number}: ");
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

Console.WriteLine("Введите число больше единицы: ");
int cubeLimit = GetNumberToPow(Console.ReadLine() ?? "");
MakeCube(cubeLimit);
