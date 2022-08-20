// 12. Напишите программу, которая будет принимать на вход 
//два числа и выводить, является ли второе число кратным 
//первому. Если число 2 не кратно числу 1, то программа 
//выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Random random = new Random();
int num1 = random.Next(10,100);
int num2 = random.Next(1,10);

Console.WriteLine("Первое число = " + num1 + "\nВторое число = " + num2);

if(num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else{
    int remains = num1 % num2;
    Console.WriteLine("Не кратно, остаток = " + remains);

}