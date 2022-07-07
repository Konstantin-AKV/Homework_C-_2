// Задача 19: Палиндром или нет?
Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());

int a1 = N / 10000;
int a2 = N % 10;
int a3 = N / 1000 % 10;
int a4 = N % 100 / 10;

if (a1 == a2 && a3 == a4)
{
    Console.WriteLine("палиндром");
}
else Console.WriteLine("не палиндром");
