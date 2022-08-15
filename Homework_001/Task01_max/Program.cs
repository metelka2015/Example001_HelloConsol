// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Программа для выдачи max");
Console.WriteLine("Введите первое число");
string? numberString = Console.ReadLine();
int number1 = int.Parse(numberString);

Console.WriteLine("Введите второе число");
string? numberString1 = Console.ReadLine();
int number2 = int.Parse(numberString1);

int max = number1;

if(number2 > max) max = number2;

Console.WriteLine("Максимальное число = " + max);
