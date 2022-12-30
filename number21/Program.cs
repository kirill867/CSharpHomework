


int PointCoordinate(string message)
{
    int number;
    while (true){
        if ((!int.TryParse(message, out number)))
        {
            Console.WriteLine("Неверный ввод, введите число: ");
            message = Console.ReadLine() ?? "";
        }
        else
        {
            break;
        }
    }
    return number;
}


double FindDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(distance, 2);
}



Console.WriteLine("Введите координату x для первой точки: ");
int x1 = PointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату y для первой точки: ");
int y1 = PointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату z для первой точки: ");
int z1 = PointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату x для второй точки: ");
int x2 = PointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату y для второй точки: ");
int y2 = PointCoordinate(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату z для второй точки: ");
int z2 = PointCoordinate(Console.ReadLine() ?? "");

Console.WriteLine($"Расстояние между точками равно {FindDistance(x1, x2, y1, y2, z1, z2)}");

