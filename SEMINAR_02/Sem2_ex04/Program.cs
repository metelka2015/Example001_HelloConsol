// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите целое число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine(number + " кратно 7 и 23 одновременно");
}
else
    Console.WriteLine(number + " не кратно 7 и 23");