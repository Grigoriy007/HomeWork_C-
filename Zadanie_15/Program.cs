Console.Write ("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number <= 0)
{
    Console.WriteLine ("Ошибка ввода: выбранное число не соответствует какому-либо из дней недели");
}
else if (number == 6)
{
    Console.WriteLine ("Ура, сегодня Суббота");
}
else if (number == 7)
{
    Console.WriteLine ("Ура, сегодня Воскресенье");
}
    else
        {
            Console.WriteLine ("Сегодня будний день");
        }
