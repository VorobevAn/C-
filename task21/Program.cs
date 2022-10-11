
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите Ax: ");
int Ax = int.Parse(Console.ReadLine());

Console.Write("Введите Ay: ");
int Ay = int.Parse(Console.ReadLine());

Console.Write("Введите Az: ");
int Az = int.Parse(Console.ReadLine());

Console.Write("Введите Bx: ");
int Bx = int.Parse(Console.ReadLine());

Console.Write("Введите By: ");
int By = int.Parse(Console.ReadLine());

Console.Write("Введите Bz: ");
int Bz = int.Parse(Console.ReadLine());

double rezult = Math.Sqrt(Math.Pow((Bx-Ax), 2) + Math.Pow((By-Ay), 2) + Math.Pow((Bz-Az), 2));

Console.WriteLine(Math.Round(rezult,2));
