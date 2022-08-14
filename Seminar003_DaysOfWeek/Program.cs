// Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3-> среда, 5->пятница
Console.WriteLine("Программа выдачи дней недели");
Console.WriteLine("Введите целое число от 1 до 7");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString);

if(number < 1) Console.WriteLine("Ошибка. Введите целое число от 1 до 7");

if(number > 7) Console.WriteLine("Ошибка. Введите целое число от 1 до 7");

if(number == 1) Console.WriteLine("Понедельник");

else if(number == 2) Console.WriteLine("Вторник");

else if(number == 3) Console.WriteLine("Среда");

else if(number == 4) Console.WriteLine("Четверг");

else if(number == 5) Console.WriteLine("Пятница");

else if(number == 6) Console.WriteLine("Суббота");

else if(number == 7) Console.WriteLine("Воскречение");

