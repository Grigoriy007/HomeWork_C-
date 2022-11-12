// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int[,] FillArray(int rows, int columns, int min, int max)
{
    var arr = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


int FindSumm(int[,] array)
{
    int sum = default;
    int minSum = default;
    int index = 1;

    for (int k = 0; k < array.GetLength(1); k++)
    {
        minSum = minSum + array[0, k];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            index = i + 1;
        }
        sum = default;
    }
    return index;
}


int[,] array2d = FillArray(6, 4, 0, 9);
PrintArray(array2d);
int answer = FindSumm(array2d);
Console.WriteLine($"Строка с наименьшей суммой элементов: {answer}");