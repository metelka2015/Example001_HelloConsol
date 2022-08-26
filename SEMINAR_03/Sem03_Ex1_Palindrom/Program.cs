// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool CheckPalindrome(int number){
    int digit1 = number / 10000;
    int digit5 = number % 10;
    
    if(digit1 != digit5)
        return false;
    
    int digit2 = number / 1000 % 10;
    int digit4 = number % 100 / 10;

    if(digit2 != digit4)
        return false;
    
    return true;

}
Console.WriteLine("Введите пятизначное число для проверки");
var numberString = Console.ReadLine();
var number = int.Parse(numberString);

if(number < 10000 && number >= 100000){
    return;
}
var result = CheckPalindrome(number);

if(result)
    Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");