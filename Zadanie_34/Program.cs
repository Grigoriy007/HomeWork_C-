// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray (int [] arr)
{
    int length = arr.Length;
    Console.Write ("Массив: [");
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100, 999);

        if (i < length-1)
        {
            Console.Write (arr[i] + ", ");
        }
        else
        {
            Console.Write ($"{arr[i]}]");
        }
    }  
}

void Result (int [] control)
{
    int length = control.Length;
    int count = 0;

    for (int j = 0; j < length; j++)
    if (control[j] % 2 == 0)
    {
        count =  count + 1;
    }
    Console.WriteLine ($"Количество четных чисел в массиве: {count}");
}

int [] array = new int [6];
FillArray (array);
Console.WriteLine();
Result (array);