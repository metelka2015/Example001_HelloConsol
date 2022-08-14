// Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3-> среда, 5->пятница
Console.WriteLine("Программа выдачи дней недели");
Console.WriteLine("Введите целое число от 1 до 7");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString);

if(number < 1) Console.WriteLine("Ошибка. Введите целое число от 1 до 7");

if(number > 7) Console.WriteLine("Ошибка. Введите целое число от 1 до 7");

if(number == 1) Console.WriteLine("Понедельник");

if(number == 2) Console.WriteLine("Вторник");

if(number == 3) Console.WriteLine("Среда");

if(number == 4) Console.WriteLine("Четверг");

if(number == 5) Console.WriteLine("Пятница");

if(number == 6) Console.WriteLine("Суббота");

if(number == 7) Console.WriteLine("Воскречение");

