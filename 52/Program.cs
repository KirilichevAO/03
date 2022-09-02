// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},");
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(x, y, 1, 5);
PrintMatrix(array2D);

for (int i = 0; i < x; i++)
{
    double average = 0;

    for (int j = 0; j < y; j++)
    {
        average += array2D[j, i];
    }
    average = Math.Round(average / x, 1);
    Console.WriteLine($"Среднее арифметическое каждого столбца: {average}");
}