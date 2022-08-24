// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); // генерируем псевдослучайные числа от 10 до 99
Console.WriteLine($"Случайное число из отрезка от 10 до 99 -> {number}"); // выводим число

//int firstDigit = number / 10; // получаем первую цифру числа
//int secondDigit = number % 10; // получаем вторую чифру числа

//if (firstDigit == secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> Цифры одинаковые"); // сравниваем цифры и выводим наибольшую цифру
//else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}"); // сравниваем цифры и выводим наибольшую цифру
//else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}"); // сравниваем цифры и выводим наибольшую цифру

//int res = firstDigit > secondDigit ? firstDigit : secondDigit; // аналог записи 12 - 14 строк (? - тогда, : - иначе)
//Console.WriteLine($"Наибольшая цифра числа {number} -> {res}"); // выводим результат

int MaxDigit(int num) // создаем метод
{   
    int firstDigit = num / 10; // получаем первую цифру числа
    int secondDigit = num % 10; // получаем вторую чифру числа
    //if (firstDigit > secondDigit) return firstDigit; // выводим первое число
    //return secondDigit; // выводим второе число
    if (firstDigit == secondDigit) return -1; // если цифры равны
    return firstDigit > secondDigit ? firstDigit : secondDigit; // аналог записи 25 - 26 строк (? - тогда, : - иначе)
}

int result = MaxDigit(number); // присваеваем новой переменной рандомное значение
string res = result == -1 ? "Цифры равны" : result.ToString(); // присваеваем переменной полученное значение и переводим ее в строку
//int result2 = MaxDigit(34); // присваеваем новой переменной значение 34 для проверки
//Console.WriteLine($"Наибольшая цифра числа {number} -> {result}"); // выводим результат работы метода
Console.WriteLine($"Наибольшая цифра числа {number} -> {res}"); // выводим результат работы метода
//Console.WriteLine($"Наибольшая цифра числа {34} -> {result2}"); // выводим результат работы метода