// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write ("Введите координаты x точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты y точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты z точки А: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты x точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

int Q = Bx - Ax;
int W = By - Ay;
int E = Az - Bz;
    
double lenght = Math.Sqrt((Q * Q) + (W * W) + (E * E));

Console.Write ($"Расстояние между точками А и В в 3D пространстве составляет: {lenght}");

