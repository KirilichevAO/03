// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintQuart(int num)
{
    for (int i = 1; i <= num; i++)
    Console.WriteLine($"{i} \t {i*i}");
}
if (number < 1)
{
    Console.WriteLine("Введите число > 1");
    return;
}
PrintQuart(number);