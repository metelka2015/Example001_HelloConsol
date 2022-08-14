// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 
Console.WriteLine("Программа проверки квадрата числа");

Console.WriteLine("Введите первое число ");

string? number1 = Console.ReadLine();

int a = int.Parse(number1);

Console.WriteLine("Введите второе число");

string? number2 = Console.ReadLine();

int b = int.Parse(number2);

if(a == b * b)
{
    Console.WriteLine("Yes");
}
else 
    Console.WriteLine("No");