﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.Clear(); // очистка консоли
Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine()); // заносим в переменную введенное число

string GetQuarter(int num) // создаем метод
{
if (num == 1) return "X > 0 и Y > 0"; // выводим ответ с диапазоном (return - прерывает проверку)
if (num == 2) return "X < 0 и Y > 0"; // выводим ответ с диапазоном
if (num == 3) return "X < 0 и Y < 0"; // выводим ответ с диапазоном
if (num == 4) return "X > 0 и Y < 0";  // выводим ответ с диапазоном
return "Введена некорректная четверть"; // выводим ответ если ввели неправельное значение
}
string result = GetQuarter(number); // заносим в переменную результат работы метода
Console.WriteLine(result); // выводим результат на экран