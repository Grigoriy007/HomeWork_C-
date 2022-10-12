Console.Write ("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int size = number.ToString().Length;

if (size > 2)
{
    string str = number.ToString();
    Console.WriteLine (str[2]);

}
else
{
    Console.WriteLine ("Третьей цифры нет");

}