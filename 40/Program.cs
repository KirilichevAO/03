// Напишите программу, которая на вход принимает три числа и проверяет,
// может ли существовать треугольник с сторонами такой длинны.

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

bool ExistTriangle(int a, int b, int c)
{
    return a < (b + c) && b < (a + c) && c < (a + b);
}
bool result = ExistTriangle(a, b, c);
if(result)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}