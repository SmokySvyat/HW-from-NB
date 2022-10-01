// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void ShowSecondNumber()
{
    Console.WriteLine("Введите трёхзначное число");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(a / 10 % 10);
}

void ShowThirdNumber()
{
    Console.WriteLine("Введите число");
    int b = int.Parse(Console.ReadLine());

    if (b > 99 & b < 1000)
    {
        Console.WriteLine(b % 10);
    }
    else if (b > 999 & b < 10000)
    {
        Console.WriteLine(b / 10 % 10);
    }
    else if (b > 10000)
    {
        Console.WriteLine("Много цифр");
    }
    else
    {
        Console.WriteLine("Третьего числа нет.");
    }
}

void WhenWeekend()
{
    Console.WriteLine("Введите порядковый номер дня недели");
    int c = int.Parse(Console.ReadLine());

    if (c == 6 ^ c == 7)
    {
        Console.WriteLine("Сегодня выходной!");
    }
    else
    {
        Console.WriteLine("Иди поработай...");
    }
}



Console.WriteLine("Введи число, что бы посмотреть функцию:");
Console.WriteLine("1 - Показать второе число");
Console.WriteLine("2 - Показать третье число");
Console.WriteLine("3 - Когда выходные?");
int taskNum = int.Parse(Console.ReadLine());
    if (taskNum == 1)
    {
        ShowSecondNumber();
    }
    if (taskNum == 2)
    {
        ShowThirdNumber();
    }
    if (taskNum == 3)
    {
        WhenWeekend();
    }
