/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = 0;
    int.TryParse(Console.ReadLine(), out number);
    return number;
}

int [,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    int [,] arr = new int[rows, columns];
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            arr[row,column] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void SortRows(int [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            int maxValue = array[row, column];
            int [] indexes = {row, column};
            for (int i = column + 1; i < array.GetLength(1); i++)
            {
                if (array[row, i] > array[row, column])
                {
                    maxValue = array[row, i];
                    indexes[1] = i;
                    int temp = array[row, column];
                    array[row, column] = maxValue;
                    array[indexes[0], indexes[1]] = temp;
                }
            }

        }
    }
}

void PrintArray(int [,] array)
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


int row = GetNumber("Введите количество строк");
int column = GetNumber("Введите количество столбцов");
int [,] array = CreateArray(row, column);
PrintArray(array);
SortRows(array);
Console.WriteLine();
PrintArray(array);
