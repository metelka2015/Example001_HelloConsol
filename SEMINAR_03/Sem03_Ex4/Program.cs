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

for (;;)
{
    Console.WriteLine("Введите положительное число: ");
    Console.WriteLine("Для выхода нажмите Y");
    
    var inputString = Console.ReadLine();

    if (inputString.Equals("Y"))
        break; //выход из цикла, return - выход из программы.

    if (int.TryParse(inputString, out var number))
    {
        if (number < 0)
        {
            Console.WriteLine("Число должно быть неотрицательным");
            continue; // опеатор, который продолжает работы цикла, перебрасывая на следующую операцию цикла. 
        }
        int result = Factorial(number);
        Console.WriteLine($"{number}! = {result}");
    }

    else Console.WriteLine("Введено не число!");

}


