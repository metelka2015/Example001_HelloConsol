// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Программа вывода всех целых чисел от -N до N");
Console.WriteLine("Введите целое число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString);
int count = 0;


if(number < 0) number = number * (-1);

int index = number * (-1);

// while(count <= number * 2)

// {
//     Console.WriteLine(index);
//     index = index + 1;
//     count = count + 1;

// }

while(index<=number)
    Console.WriteLine(index++);

