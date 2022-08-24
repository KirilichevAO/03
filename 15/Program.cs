// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void TheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7) Console.WriteLine($"{dayNum} -> да");
    else if (dayNum < 1 || dayNum > 7) Console.WriteLine("Это не день недели");
    else Console.WriteLine($"{dayNum} -> нет");
}

TheWeek(dayNumber);
