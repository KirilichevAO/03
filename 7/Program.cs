﻿//Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
//1. Установить счетчик index в позицию 0
//2. Если array [index] = find, алгоритм завершил работу успешно.
//3. Увеличить index на 1
//4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 }; // создаем массив

int n = array.Length; // колличество элементов в массиве определяется автоматически при помощи команды .Length

int find = 18; // введенное пользователем число

int index = 0; // счетчик на 0

while (index < n) // Ззпускаем цикл
{
    if(array[index] == find) // если элемент массива СОВПАДАЕТ (==) с find, то показываем результат
    {
        Console.WriteLine(index); // показываем результат

        break; // прерывание после определения первого элемента
    }
    //index = index + 1;
    index++; // сокращенный вариант
}