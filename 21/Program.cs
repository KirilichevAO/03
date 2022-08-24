// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A:");
Console.Write("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int bz = Convert.ToInt32(Console.ReadLine());

double GetDist(int axc, int ayc, int azc, int bxc, int byc, int bzc)
{
    return Math.Round(Math.Sqrt((axc - bxc) * (axc - bxc) + (ayc - byc) * (ayc - byc) + (azc - bzc) * (azc - bzc)) , 2, MidpointRounding.ToZero);
}
Console.WriteLine(GetDist(ax, ay, az, bx, by, bz));