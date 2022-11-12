// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




// Метод возведения одного числа в степень другого
void Degree (int a, int b)
{
    int result = 1;
    for (int count = 1; count<=b; count++)
    {
        result = result * a;
    }   
    Console.WriteLine($"Результат возведения в степень равен: {result}");
}

// Метод ввода данных

int EnterNumber (string message)
{
Console.Write (message);
return Convert.ToInt32(Console.ReadLine()); 
}

int NumberA = EnterNumber ("Введите число А: ");
int NumberB = EnterNumber ("Введите число B: ");
Degree (NumberA, NumberB);

