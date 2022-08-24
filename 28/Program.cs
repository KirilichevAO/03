// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CompositionNumber(int num)
{
    int compos = 1; 
    for (int i = 1; i <= num; i++)
    {
        compos = compos * i;
    }
    return compos;
}
int result = CompositionNumber(number);
Console.WriteLine($"{number} -> {result}");