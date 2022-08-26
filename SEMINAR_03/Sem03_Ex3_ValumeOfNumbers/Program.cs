// Решение преподавателя.  Задача 26: Напишите программу, которая принимает на 
// вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int Digits(int num)
{
if (num == 0)
return 1;

for (var i = 1; i < 100; i++) {
num = num / 10;

if (num == 0)
return i;
}

return -1;
}


if (int.TryParse(Console.ReadLine()!, out var number))
{
var result = Digits(number);

Console.WriteLine(result);

} else {
Console.WriteLine("Введено не число или слишком большое число!");
}