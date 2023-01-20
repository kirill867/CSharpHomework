
/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

все 8 элементов должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split();
*/


int[] Array(string stringArray)
    {
        var array = stringArray.Split(',');
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = int.Parse(array[i]);
            
        }
        
        return result;
        
    }



string stringArray;
stringArray = Console.ReadLine();

int []arr = Array(stringArray);


Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ", ");
}
Console.Write("]");
