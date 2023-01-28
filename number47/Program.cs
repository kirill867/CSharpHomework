// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNumber(string message)
{   int result;
    Console.WriteLine(message);
    result = int.Parse(Console.ReadLine());
    return result;
}

double [,] CreateArray(int rows, int columns)
{
    double [,] arr = new double [rows, columns];
    Random rnd = new Random();
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            arr[row, column] = Math.Round(rnd.NextDouble() * 10.0, 2);
        }
    }
    return arr;
}

void PrintArray(double [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
double [,] arr = CreateArray(rows, columns);
PrintArray(arr);