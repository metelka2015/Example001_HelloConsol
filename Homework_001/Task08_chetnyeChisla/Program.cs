// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа всех четных чисел");
Console.WriteLine("Введите целое положительное число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString);
int index = 1;
if(number >= 0) 
{
    while(index <= number)
        {
        if(index%2 == 0)
        {
            Console.WriteLine(index);
            index++;
        }
        else
          index++;  
        }
    
}
else
{
    Console.WriteLine("Ошибка. Введите целое положительное число");
}
