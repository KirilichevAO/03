// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

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

bool GetNumbers(int[] array, int num) // метод по нахождению сумм
{
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] == num) return true; 
    }
    return false;
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

int[] a = CreateArrayRndInt(5, 0, 15);
PrintArray(a);
string result = GetNumbers(a, numbers) ? "да" : "нет";
Console.WriteLine($"-> {result}");