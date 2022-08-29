// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrNum = new double[5];
for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = new Random().Next(1, 10) * 0.1;
    Console.Write($"{arrNum[i]} ");
}

double maxNum = arrNum[0];
double minNum = arrNum[0];

for (int i = 1; i < arrNum.Length; i++)
{
    if (maxNum < arrNum[i]) maxNum = arrNum[i];
    if (minNum > arrNum[i]) minNum = arrNum[i];
}

double diff = maxNum - minNum;

Console.WriteLine($"-> {diff}");