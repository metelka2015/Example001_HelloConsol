// Напишите программу, которая выводит случайное число из отрезка [10,99] 
//и показывает наибольшую цифру числа. 
// 78-> 8, 12 -> 2, 85 -> 8

var random = new Random();

int randomNumber = random.Next(10, 99);

Console.WriteLine(randomNumber);

int firstDigit = randomNumber % 10;

int secondDigit = randomNumber / 10;

if(firstDigit > secondDigit)
    Console.WriteLine(firstDigit);
else
    Console.WriteLine(secondDigit);