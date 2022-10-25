// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Метод на сумму чисел

void FindSumm (int number)
{
    var str = number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
    int lenght = number.ToString().Length;
    int result = 0;
    for (int i = 0; i <= lenght-1; i++)
    {

        result = result + str [i];

    }
    Console.WriteLine ($"Сумма равна: {result}");
}

// Метод на ввод цифры

int WriteNumber (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}

int summ = WriteNumber ("Введите число: ");
FindSumm (summ);