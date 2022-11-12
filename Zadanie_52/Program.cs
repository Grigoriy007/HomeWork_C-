// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintArray(double[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write($"  {print[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] fill)
{
    Random rnd = new Random();
    for (int a = 0; a < fill.GetLength(0); a++)
    {
        for (int b = 0; b < fill.GetLength(1); b++)
        {
             fill[a,b] = rnd.Next(1,100);
        }

    }
}

void ArefArray(double[,] arr)
{
    double aref = 0;
    for (int b = 0; b < arr.GetLength(1); b++)
    {
        double sum = 0;
        for (int a = 0; a < arr.GetLength(0); a++)
        {
            sum = sum + arr[a,b];
            
        }
        aref = sum / arr.GetLength(0);
        Console.WriteLine ($"Среднее арефметическое значений из столбца {b+1} равно: {aref}");
    }
    
}

double [,] result = new double [3,4];
FillArray (result);
PrintArray (result);
ArefArray (result);