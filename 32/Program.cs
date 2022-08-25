// Напишите программу замена элементов массива: положительные элементы заменить на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max) // метод по заполнению массива
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] ReplayPosElemArray(int[] array) // метод по замене
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }
    return array;
}

void PrintArray(int[] array) // метод по выводу
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] a = CreateArrayRndInt(4, -10, 10);
PrintArray(a);
int[] b = ReplayPosElemArray(a);
PrintArray(b);