// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int number)
{
    int prevPrev = 0;
    int prev = 1;

    Console.Write($"{prevPrev} {prev} ");

    for (int i = 3; i <= number; i++)
    {
        int result = prev + prevPrev;

        Console.Write($"{result} ");

        prevPrev = prev;
        prev = result;
    }
}

Fibonacci(n);
Console.WriteLine();