// Напишите программу, которая на вход принимает число А 
// и выдает сумму чисел от 1 до А. 
// 7 -> 28, 4->10, 8 ->36

int SumFrom1ToA(int a)
{
    int result = 0;

    for (var i = 0; i <= a; i++)
        result += i;
    return result;
}


var number = int.Parse(Console.ReadLine()!);

if (number <= 0)
    return;
var result = SumFrom1ToA(number);

Console.WriteLine(result);




