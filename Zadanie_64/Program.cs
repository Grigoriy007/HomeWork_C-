// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int EnterNumber (string message)
{
Console.Write (message);
return Convert.ToInt32(Console.ReadLine()); 
}

void FindBetween (int numberN)
{
    if (numberN == 0) return;
    else
    Console.Write ($"{numberN}  ");
    FindBetween (numberN-1);
    

}


int number = EnterNumber ("Введите число N: ");
Console.Write ($"N = {number} -> ");
FindBetween (number);