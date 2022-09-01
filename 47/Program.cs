﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5      7     -2   -0,2
//   1   -3,3      8   -9,9
//   8    7,8   -7,1      9

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 9;
        }
    }
}

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");

        for (int j = 0; j < array.GetLength(1); j++)
        {
            double smallNum = Math.Round(array[i, j], 1);
            Console.Write(smallNum + " ");

        }
        Console.WriteLine("]");
    }
}

CreateArrayDouble(array);
PrintArrayDouble(array);
Console.WriteLine();