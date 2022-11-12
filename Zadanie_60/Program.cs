// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArray(int rows, int columns, int height, int min, int max)
{
    var arr = new int[rows, columns, height];
    int[] check = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    var rnd = new Random();

    for (int i = 0; i < check.Length; i++)
    {
        check[i] = rnd.Next(min, max + 1);

        if (i >= 1)
            for (int j = 0; j < i; j++)
            {
                while (check[i] == check[j])
                {

                    check[i] = rnd.Next(min, max + 1);
                    j = 0;

                }
            }
    }
    int count = 0;
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[x, y, z] = check[count];
                count++;
            }
        }

    }
    return arr;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],5} {(i, j, k)}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array3d = FillArray(2, 2, 2, 10, 99);
PrintArray(array3d);