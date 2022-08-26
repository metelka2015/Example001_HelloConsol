// Задача 28: Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int digit)
{

    int result = 1;
    for (int i = 1; i <= digit; i++)
    {
        result = i * result;
    }
    return result;

}

if (int.TryParse(Console.ReadLine()!, out var number))
{
    if (number >= 0)
    {
        int result = Factorial(number);
        Console.WriteLine($"{number}! = {result}");
    }
    else Console.WriteLine("Введите положительное число");
}
else Console.WriteLine("Введено не число!");

