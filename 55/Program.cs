// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},"); // убираем последнюю запятую при выводе
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

void ReplaceMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        Console.WriteLine("Невозможно вывести матрицу!!!");
        return;
    }
    
    for (int i = 0; i < x; i++)
    {
        for (int j = i +1; j < y; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] array2D = CreateMatrixRndInt(x, y, -9, 9);
PrintMatrix(array2D);
Console.WriteLine();
ReplaceMatrix(array2D);