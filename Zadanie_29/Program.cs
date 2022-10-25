// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Первый способ: но он показался мне слишком простым:

// int[] array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 3,};
// Console.Write($"Массив:[{array[0]}, {array[1]}, {array[2]}," +
// $" { array[3]}, { array[4]}, { array[5]}, " +
// $"{ array[6]}, { array[7]}]");


// Второй способ:

void FillArray (int [] array)
{
    int lenght = array.Length;

    for (int i = 0; i < lenght; i++) 
    {
        Console.WriteLine ($"Введите элемент массива [{i}]");
        int A = Convert.ToInt32(Console.ReadLine());
        array [i] = A;   
    }
}

void NewArray (int [] arr)

{
    int count = arr.Length;
    Console.Write ("Массив: [");
    for (int i = 0; i < count; i++)
    {
        if (i < count - 1)
        Console.Write(arr [i] + ", ");
        else 
        Console.Write(arr [i]);
    }
    Console.Write ("]");
}

int [] array = new int [3];

FillArray (array);
NewArray (array);
