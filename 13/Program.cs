// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText.Length > 2)
// {
//     Console.WriteLine($"{num} третья цифра -> " + numText[2]);
// }
// else
// {
//     Console.WriteLine($"{num} -> третьей цифры нет");
// }

int ThreeNum(int number)
{
    if (number > 99)
    {
        while (number > 1000 && number < -1000)
        {
            number = number / 10;
        }
        return number % 10;
    }
    else return -1;
}

int res = ThreeNum(num);

if (res != -1)
{
Console.WriteLine($"Третья цифра заданного числа -> {res}");
}
else
{
Console.Write("Третьей цифры нет.");
}
