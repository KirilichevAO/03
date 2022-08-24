// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: "); // просим ввести число
int number = Convert.ToInt32(Console.ReadLine()); // присваиваем переменной введенное число

bool Multiplicity(int num, int a, int b) // создаем метод
{
    return num % a == 0 && num % b == 0; // возвращает TRUE если метод работает
}

if (Multiplicity(number, 7, 23)) Console.WriteLine($"{number} -> Да"); // выводим результат при совпадении условия
else Console.WriteLine($"{number} -> Нет"); // выводим результат при совпадении условия