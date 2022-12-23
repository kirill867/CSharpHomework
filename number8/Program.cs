Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

for (int i = 2; i <= num; i += 2)
{
    Console.Write(i + " ");
}
