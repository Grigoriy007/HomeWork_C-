Console.WriteLine("Введите номер строки: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int n = Convert.ToInt32 (Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
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

int FindElement(int[,] arr, int num1, int num2)
{
    int x = arr.GetLength(0);
    int z = arr.GetLength(1);
    int y = default;
    for (int i = 0; i < arr.GetLength (0); i++)
    {
        for (int j = 0; j < arr.GetLength (1); j++)
        {
            if (i == num1 && j == num2)
            y = arr [i, j];
        }
    }
    return y;
}

bool Element (int[,] arr, int num1, int num2)
{  
    
    {
        return (num1 >= arr.GetLength (0) || num2 >= arr.GetLength (1));

    }
  
}

int [,] array2d = CreateMatrixRndInt (3,4,0,9);
PrintMatrix (array2d);
FindElement (array2d,m,n);
int answer = FindElement (array2d,m,n);
bool tadam = Element (array2d,m,n);
if (tadam) Console.WriteLine($"Элемента с позицией {m} и {n} нет в массиве");

else Console.WriteLine($"Значение элементов двумерного массива: {answer}");