
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string namber = Console.ReadLine();

char[] num = new char[5];
for (int i = 0; i < 5; i++)
    num[i] = namber[i];

if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


// Console.WriteLine(num[0] );
// Console.WriteLine(num[4] );


