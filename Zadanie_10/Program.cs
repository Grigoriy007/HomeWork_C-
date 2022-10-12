Console.Write ("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int size = number.ToString().Length;

if (size > 3 || size < 3)
{
    Console.WriteLine ("Введенное число не является трехзначным");

}
else
    {
        int answer = (number / 10) % 10;
        Console.WriteLine (answer);
    }