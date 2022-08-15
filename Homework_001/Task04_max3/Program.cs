// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа для выдачи max");
Console.WriteLine("Введите первое число");
string? numberString1 = Console.ReadLine();
int number1 = int.Parse(numberString1);

Console.WriteLine("Введите второе число");
string? numberString2 = Console.ReadLine();
int number2 = int.Parse(numberString2);

Console.WriteLine("Введите третье число");
string? numberString3 = Console.ReadLine();
int number3 = int.Parse(numberString3);

int max = number1;

if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.WriteLine("Максимальное число = " + max);
