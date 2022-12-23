 Console.Write("Введите число: ");
int even = int.Parse(Console.ReadLine() ?? "0");
if (even % 2 != 0)
{
    Console.WriteLine($"Число {even} нечетное");
}
else
{
    Console.WriteLine($"Число {even} четное");
}