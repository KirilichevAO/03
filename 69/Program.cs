// Напишите программу, которая на вход принимает два числа A и B,
// и возвращает число A в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3 в 5)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число: ");
int b = Convert.ToInt32(Console.ReadLine());

int pow = GetPower(a, b);

int GetPower(int number, int p)
{
    if (p == 0) return 1;
    if (p == 1) return number;
    return number * GetPower(number, p - 1);
}

Console.WriteLine($"{pow}");