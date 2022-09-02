// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];

// void CreateArrayDouble(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble() * 9;
//         }
//     }
// }

// void PrintArrayDouble(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             double smallNum = Math.Round(array[i, j], 1);
//             Console.Write(smallNum + " ");

//         }
//         Console.WriteLine("]");
//     }
// }

// int[] SerchNum(string input)
// {
//     int countNum = 1;

//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',') countNum++;
//     }

//     int[] num = new int[countNum];
//     int numIndex = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string subString = String.Empty;

//         while (input[i] != ',')
//         {
//             subString += input[i].ToString();
//             if (i >= input.Length - 1)
//                 break;
//             i++;
//         }
//         num[numIndex] = Convert.ToInt32(subString);
//         numIndex++;
//     }
//     return num;
// }

// CreateArrayDouble(array);
// PrintArrayDouble(array);
// Console.WriteLine();

// Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

// string? positionElement = Console.ReadLine();
// int[] pos = SerchNum(positionElement);

// if (pos[0] <= m && pos[1] <= n && pos[0] >= 0 && pos[1] >= 0)
// {
//     double result = Math.Round(array[pos[0] - 1, pos[1] - 1], 1);
//     Console.WriteLine($"Значение элемента: {result}");
// }
// else Console.Write($"Такого элемента нет!");

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(x, y, -9, 9);
PrintMatrix(array2D);

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 <= x - 1 && num2 <= y - 1)
{
    Console.WriteLine($"{num1}, {num2} -> {array2D[num1, num2]}");
}

else Console.WriteLine($"Такого элемента нет!");