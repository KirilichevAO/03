// Напишите программу, которая принимает на входе два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.Write("Введите первое число: "); // просим ввести число
int number1 = Convert.ToInt32(Console.ReadLine()); // присваиваем переменной введенное число

Console.Write("Введите второе число: "); // просим ввести число
int number2 = Convert.ToInt32(Console.ReadLine()); // присваиваем переменной введенное число

bool IsSquare(int num1, int num2) // создаем метод
{
    return num1 == num2 * num2 || num2 == num1 * num1; // проверяем на квадрат друг друга
}

if (IsSquare(number1, number2)) Console.WriteLine($"{number1}, {number2} -> Да"); // если TRUE тогда ок
else Console.WriteLine($"{number1}, {number2} -> Нет");