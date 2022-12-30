
string GetNumber(string message)
{
    int number;
    while (true){
        if ((!int.TryParse(message, out number)))
        {
            Console.WriteLine("Неверный ввод, введите число: ");
            message = Console.ReadLine() ?? "";
        }
        else if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Неверный ввод, введите пятизначное число: ");
            message = Console.ReadLine() ?? "";            
        }
        else
        {
            break;
        }
    }
    return number.ToString();
}


void Palindrome(string number)
{
    string newNumber = "";
    for (int i = 0; i < number.Length; i++)
    {
        newNumber = number[i] + newNumber;
    }
    if (number == newNumber)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}


Console.WriteLine("Введите пятизначное число: ");
string message = Console.ReadLine() ?? "";
Palindrome(GetNumber(message));