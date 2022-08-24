//Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
//1. Установить счетчик index в позицию 0
//2. Если array [index] = find, алгоритм завершил работу успешно.
//3. Увеличить index на 1
//4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.

void FillArray(int[] collection) // метод
{
    int length = collection.Length; // получение длинны массива
    int index = 0; // счетчик на 0
    while  (index < length) // цикл
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col) // метод который будет печатать массив
{
    int count = col.Length; //получение длинны массива
    int position = 0; // счетчик на 0
    while (position < count) // цикл
    {
         Console.WriteLine(col[position]);
         position++; 
    }
}

int IndexOf(int[] collection, int find) // метод
{
    int count = collection.Length; // получение длинны массива
    int index = 0; // счетчик на 0
    int position = -1;
    while (index < count) // цикл
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    } 
    return position;
}

int[] array = new int[10]; // создание нового массива с 10-ю значниями

FillArray(array); // метод заполняющий массив
array[4] = 4;
array[6] = 6;


PrintArray(array); // метод  вывода массива
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);