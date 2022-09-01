// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0, 0); (1, 1)) и т.д.
// 1   4   7   2
// 5   9   2   3
// 8   4   2   4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

int sum = 0;

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // метод по созданию двумерного массива
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - размерность строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - размерность столбца
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] ConvertMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i, j];
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},"); // убираем последнюю запятую при выводе
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(8, 5, 1, 9);
ConvertMatrix(array2D);
PrintMatrix(array2D);
Console.WriteLine($"{sum}");