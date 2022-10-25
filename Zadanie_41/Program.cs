// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void FirstArray (int [] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"Введите число номер {i + 1}: ");
        int N = Convert.ToInt32(Console.ReadLine());
        array [i] = N;
    }
        
        Console.WriteLine ();
        Console.WriteLine ("Решение задачи: ");
        Console.Write ("Введенный набор чисел: ");
        for (int j = 0; j < array.Length; j++)
            {
                if (j < array.Length-1)
                {
                Console.Write (array[j] + ", ");
                }
                else
                {
                    Console.Write ($"{array[j]}");
                }
            } 
}

void SecArray (int [] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
       
        if (arr[j] > 0)
        count = count + 1;
    }
    Console.Write ($"Количество чисел больше 0 равно: {count}");
}

int [] Answer = new int [5];
FirstArray (Answer);
Console.WriteLine ();
SecArray (Answer);