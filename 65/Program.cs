// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int numM, int numN)
{
    Console.Write($"{numM} ");
    if (numM > numN) NaturalNumber(numM - 1, numN);
    else if (numM < numN) NaturalNumber(numM + 1, numN);
}

NaturalNumber(m, n);