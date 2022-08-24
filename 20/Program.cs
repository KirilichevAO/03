// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// А (3, 6); В (2, 1) -> 5,09
// А (7, -5); В (1, -1) -> 7,21

Console.Clear();

Console.WriteLine("Введите координаты точки A:");
Console.Write("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int by = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by)); // Math.Sqrt - извлечение корня
// Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero)); // Math.Roud(distance, 2) - округление до двух знаков

// Другой способ решения задачи

// double GetDist(int axc, int ayc, int bxc, int byc)
// {
//     double dx = axc - bxc;
//     double dy = ayc - byc;
//     return Math.Sqrt(dx * dx + dy * dy);
// }
// double result = GetDist(ax, ay, bx, by);
// Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));

// Другой способ решения задачи

double GetDist(int axc, int ayc, int bxc, int byc)
{
    return Math.Round(Math.Sqrt((axc - bxc) * (axc - bxc) + (ayc - byc) * (ayc - byc)), 2, MidpointRounding.ToZero);
}
Console.WriteLine(GetDist(ax, ay, bx, by));