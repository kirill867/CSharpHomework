Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a == b)
    {
        Console.WriteLine("Числа равны.");
    }

    else if (a > b)
     {
         Console.WriteLine("max: " + a);
         Console.WriteLine("min: " + b);
    }

    else
    {
         Console.WriteLine("max: " + b);
         Console.WriteLine("min: " + a);
    }