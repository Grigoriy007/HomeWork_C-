// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray (int [] arr)
{
    int length = arr.Length;
    Console.Write ("Массив: [");
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100, 100);

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
    int sum = 0;

    for (int j = 0; j < length; j++)
    if (j % 2 == 1)
    {
        sum =  sum + control [j];
    }
    Console.WriteLine ($"Сумма всех элементов, стоящих на нечетных позициях: {sum}");
}

int [] array = new int [7];
FillArray (array);
Console.WriteLine();
Result (array);