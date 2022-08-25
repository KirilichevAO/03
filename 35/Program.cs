// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10, 99].
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int CountInRange(int[] array, int min, int max)
{
    if (array == null || array.Length <= 0) return 0;

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) ++ count;
    }
    return count;
}

void PrintArray(int[] array) // метод по выводу
{
    if (array == null || array.Length <= 0)
    {
        Console.WriteLine("Массив пуст.");
    }
    
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length -1]}]");
}

int[] arr = CreateArrayRndInt(123, 0, 123);
PrintArray(arr);

int cnt = CountInRange(arr, 10, 99);
Console.WriteLine($"->{cnt}");