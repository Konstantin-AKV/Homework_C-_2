// Задача 19: Палиндром или нет?
/* Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());
int a1 = N / 10000;
int a2 = N % 10;
int a3 = N / 1000 % 10;
int a4 = N % 100 / 10;
if (a1 == a2 && a3 == a4)
{
    Console.WriteLine("Палиндром");
}
else Console.WriteLine("а это уже не палиндром");
 */

// Задача 21: Координаты в 3D пространстве.

/* Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
Console.WriteLine(Math.Round(result,2));  */

// Задача 23: Число = от него до N(в 3 степени)

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i <= N)
{
    Console.WriteLine(Math.Pow(i,3) + " ");
    i++;
}


