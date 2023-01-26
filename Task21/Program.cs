// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите X первой координаты: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y первой координаты: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z первой координаты: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите X второй координаты: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y второй координаты: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z второй координаты: ");
int z2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));
Console.WriteLine($"Расстояние между точкой A({x1},{y1},{z1}) и точкой B({x2},{y2},{z2}) равно {result:f2} ");   