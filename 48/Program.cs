// Задайте двумерный массив размера m на n, каждый элемент массива находится по формуле:
// Amn = m + n. Выведите полученный массив на экран.
//
// m = 3, n = 4
//
// 0  1  2  3
// 1  2  3  4
// 2  3  4  5

int[,] CreateMatrixSumIndex(int row, int col) // метод по созданию двумерного массива
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - размерность строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - размерность столбца
        {
            matrix[i, j] = i + j;
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

int[,] array2D = CreateMatrixSumIndex(3, 4);
PrintMatrix(array2D);