// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();

void Palindrome()
{
    Console.Clear();

    Console.WriteLine("Введите пятизначное число");
    int number = int.Parse(Console.ReadLine());

    if (number > 9999 && number < 100000)
    {
        int lst = number % 100;
        int fst = number / 1000;
        if (lst / 10 == fst % 10 && lst % 10 == fst / 10)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }

}

void dotsIn3D()
{
    Console.Clear();

    Console.WriteLine("Введите координату точки А по оси X");
    int Xa = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки А по оси Y");
    int Ya = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки А по оси Z");
    int Za = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату точки B по оси Х");
    int Xb = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки B по оси Y");
    int Yb = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки B по оси Z");
    int Zb = int.Parse(Console.ReadLine());

    Console.WriteLine("Расстояние между точками равно " + Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2)));
}

void Cube()
{
    Console.Clear();

    Console.WriteLine("Введите число");
    int N = int.Parse(Console.ReadLine());

    for (int i = 0; i <= N; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine("Что бы проверить является ли число палиндромом, введи - 1");
Console.WriteLine("Что бы найти расстояние между точками в пространстве, введи - 2");
Console.WriteLine("Что бы посмотреть таблицу квадратов до введённого числа, набери - 3");

int taskNumb = int.Parse(Console.ReadLine());

if (taskNumb == 1) Palindrome();
if (taskNumb == 2) dotsIn3D();
if (taskNumb == 3) Cube();
