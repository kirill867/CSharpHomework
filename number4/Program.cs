Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите третье число: ");
int z = int.Parse(Console.ReadLine() ?? "0");

if (x > y && x > z)
    {
        Console.WriteLine("Максимальное число: " + x);
    }
else if (y > z)
    {
        Console.WriteLine("Максимальное число: " + y);
    }
else
    {
        Console.WriteLine("Максимальное число: " + z);
    }