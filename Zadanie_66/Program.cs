// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int EnterNumber (string message)
{
Console.Write (message);
return Convert.ToInt32(Console.ReadLine()); 
}

int FindSum (int numberM,  int numberN)
{   int sum = default;
    if (numberM <= numberN) return sum += numberM + FindSum (numberM+1, numberN);
    else return sum;   
}


int numberM = EnterNumber ("Введите число M: ");
int numberN = EnterNumber ("Введите число N: ");
Console.Write ($"M = {numberM}; N = {numberN} ->  ");
int answer = FindSum (numberM, numberN);
Console.Write (answer);