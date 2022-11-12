// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write($" {print[i, j]} ");
        }
        Console.WriteLine();
    }
}


void Search (int [,] arr, int number1, int number2)
{

    int length1 = arr.GetLength(0);
    int length2 = arr.GetLength(1);
    
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            if (i == number1 && j == number2)
            Console.WriteLine ($"Значение элемента двумерного массива: {arr[number1,number2]}");
           
        }
    }
    if (number1 > length1 || number2 > length2)
    Console.WriteLine ($"Элемента с позицией {number1} и {number2} нет в массиве");

}

int IntText(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



Console.WriteLine("Заданный массив: ");
int[,] result = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintArray(result);
Console.WriteLine();
int X = IntText("Введите позицию строки: ");
int Y = IntText("Введите позицию столбца: ");
Console.WriteLine();
Search (result, X, Y);


