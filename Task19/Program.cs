// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int x = number / 1000 % 10;
int y = number / 10 % 10;
if (number / 10000 == number % 10 && x == y)
{
    Console.Write("да");
}
else
Console.Write("нет");