// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Программа определения четного числа");
Console.WriteLine("Введите целое число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString);

if(number%2 == 0)
{
    Console.WriteLine("Это чётное число");
}
else Console.WriteLine("Это нечётное число");




