// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Console.Write("Введите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] RandArray(int len)
{
    int[] arrays = new int[len];

    for (int i = 0; i < arrays.Length; i++)
    {
        arrays[i] = new Random().Next(0,2);
    }
    return arrays;
}

int[] res = RandArray(lenght);

void PrintArray(int[] res1)
{
    for (int i = 0; i < res1.Length; i++)
    {
        Console.Write($"{res1[i]}");
    }
}
PrintArray(res);