// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.
//
// 1  4  7  2       1  4 49  2
// 5  9  2  3   ->  5 81  2  9
// 8  4  2  4      64  4  4  4

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

void TransformMatrix(int[,] matrix)
{
    for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j]; // или matrix[i, j] *= matrix[i, j];
            }
        }
    }
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

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
TransformMatrix(array2D);
PrintMatrix(array2D);