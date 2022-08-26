// Задача 26: Напишите программу, которая принимает на вход
//  число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ValumeOfDigitals(int digital)
{
    int count = 1;

    for (int i = 10; digital / i > 0; i = i * 10)
        count++;
    return count;
}

// var number = int.Parse(Console.ReadLine()!);
if (int.TryParse(Console.ReadLine()!, out var number)) 
//TryParse - Если это число и получилось распарсить, то число попадает 
//в переменую number, если нет - то ничего не выводит.
{
    if (number < 0) number = number * (-1);
    var result = ValumeOfDigitals(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено не число или слишком большое число!");
}


