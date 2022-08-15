// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
// 456 ->   782 ->  918 -> 8
Console.WriteLine("Программа вывода последнего числа");
Console.WriteLine("Введите трехзначное число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString);
// int abc;
if(number - number%1000 == 0)
{
    
    if(number < 0) number = number*(-1);
    if(number - number%100 != 0 && number - number%10!= 0)
    {
        int number3 = number%10;
        Console.WriteLine(number3);
    }
    else
    Console.WriteLine("Ошибка. Введите трехзначное число");

}

else
    Console.WriteLine("Ошибка. Введите трехзначное число");


