// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintQuart(int num)
{
    for (int i = 1; i <= num; i++)
    Console.WriteLine($"{i} \t {i*i*i}");
}
if (number < 1)
{
    Console.WriteLine("Введите число > 1");
    return;
}
PrintQuart(number);