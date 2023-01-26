// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int x = 1;
while (x<=n)
{
    Console.Write($"{Math.Pow(x,3)}");
     if (x!=n) Console.Write(", ");
    x++;
}