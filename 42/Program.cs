// Напишите программу, которая будет преобразовыватьдесятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число для приобразования: ");
int number = Convert.ToInt32(Console.ReadLine());

int TransToBinary(int num)
{
    int result = 0;
    int i = 1;

    while (num > 0)
    {
        result += num % 2 * i;
        num /= 2;
        i *= 10;
    }
    return result;
}
int transToBinary = TransToBinary(number);
Console.WriteLine($"Приобразованное число {transToBinary}");

// Console.Write("Введите число для приобразования: ");
// long a = Convert.ToInt32(Console.ReadLine());

// long b = 0;
// long number = 0;
// long c = 1;
// for (int i = 0; a != 0; i++)
// {
//     b = a % 2;
//     a = a / 2;
//     c = c * 10;
//     number = number + b * c;
// }
// Console.WriteLine($"Приобразованное число {number / 10}");