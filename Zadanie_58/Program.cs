// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }

        Console.WriteLine();
    }
}


int[,] Composition(int[,] array1, int[,] array2, int[,] arrayFinal)
{

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            arrayFinal[i, j] = default;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                arrayFinal[i, j] = arrayFinal[i, j] + (array1[i, k] * array2[k, j]);
            }
        }
    }
    return arrayFinal;
}

bool ControleArray(int[,] arrayA, int[,] arrayB)
{

    return (arrayA.GetLength(0) == arrayB.GetLength(1));

}


int[,] array2dFirst = FillArray(2, 2, 0, 4);
int[,] array2dSecond = FillArray(2, 3, 0, 4);
int[,] answerFinal = new int[2, 2];
PrintArray(array2dFirst);
Console.WriteLine();
PrintArray(array2dSecond);

bool check = ControleArray(array2dFirst, array2dSecond);
if (check)
{
    int[,] answer = Composition(array2dFirst, array2dSecond, answerFinal);
    Console.WriteLine();
    PrintArray(answer);
}
else Console.WriteLine("Матрицы нельзя перемножить");