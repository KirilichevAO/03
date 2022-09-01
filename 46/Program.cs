// Задайте двумерный массив размером mxn, заполненный случайными целыми числами.
// m = 3, n = 4
//
//  1   4   8   19
//  5  -2  33   -2
// 77   3   8    1

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

int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
PrintMatrix(array2D);