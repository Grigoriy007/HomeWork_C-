int a = -9;
int b = -3;

int max = a;
int min = b;

if(a > b)
{
    max = a;
    min = b;
}

if (b > a)
{
    max = b;
    min = a;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);

Console.Write("Минимальное число: ");
Console.WriteLine(min);