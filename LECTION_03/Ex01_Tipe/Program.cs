// ТИПЫ МЕТОДОВ
// Вид 1  - которые ничего не принимают и ничего не возвращают. 

void Method1()
{
    Console.WriteLine("Автор..");
}

// Method1(); //вызов этого метода




//Вид 2  - которые принимают аргументы, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2("Text massege"); //вызов функции для одного аргумента

void Method21(string msg, int count)
{
    
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}

//Method21(count: 4, msg: "Text massege"); // Если используем именнованные аргументы, то неоязательно писать их по порядку





//Вид 3 - если не принимают аргументы, но возвращают 
// Необходимо указать тип данных, значение которых мы ожидаем.
int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// Console.WriteLine(year);




//Вид 4 - методы, которые что-то принимаю и что-то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //String.Empty - пустая строка

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// string res = Method4(10, "w");
// Console.WriteLine(res);
