int[,,] CreateMatrixRndInt(int row, int columns, int depth, int min, int max)
{
    var matrix = new int[row, columns, depth];
    var number = new Random().Next(10, 99);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i, j, k] = number;
            number+=1;
        }
    }
    }
    return matrix;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k], 4} [{i}, {j}, {k}]");
            }
            Console.WriteLine();

        }
    }
}

int[,,] array3d = CreateMatrixRndInt(2, 2, 2, 1, 10);
PrintArray(array3d);