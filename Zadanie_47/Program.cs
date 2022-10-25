// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray (double [,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
     {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
     }
}


void PrintArray (double [,] print)
{    
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write ($" {print[i,j]} ");
        }
        Console.WriteLine ();
    }

}

double [,] final = new double [3,4];
FillArray (final);
PrintArray (final);