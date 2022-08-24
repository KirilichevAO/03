// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = 1; i <= num; i++)
// {
//     //sum = sum + i;
//     sum += i;
// }

// Console.WriteLine($"Cумму чисел от 1 до {num} = {sum}");


int SumNumbers(int number)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        //sum = sum + i;
        sum += i;
    }

    return sum;
}

int result = SumNumbers(num);

Console.WriteLine($"Cумму чисел от 1 до {num} = {result}");