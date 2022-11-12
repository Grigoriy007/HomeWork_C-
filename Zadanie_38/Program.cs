// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray (double [] arr)
{
    int length = arr.Length;
    Console.Write ("Массив: [");
    for (int i = 0; i < length; i++)
    {
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

void SubS (double [] chis)
{

int length = chis.Length;
double max = chis [0];
double min = chis [0];
double subtraction = 0;
for (int i = 0; i < length; i++)
{
if (chis[i] > max) max = chis[i];
if (chis [i] < min) min = chis[i];
}
subtraction = max - min;
 Console.Write ($"Разница между максимальным и минимальным элементом массива равна: {subtraction}");
}

double [] numbers = {3, 99.7, 22, 2.5, 78.3};
FillArray (numbers);
Console.WriteLine ();
SubS (numbers);