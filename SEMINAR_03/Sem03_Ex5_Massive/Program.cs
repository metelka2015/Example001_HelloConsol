// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] massive)
{
    int length = massive.Length;
    var random = new Random(); 
    int i = 0;
    while (i < length)
    {
        massive[i] = random.Next(0, 2);
        i++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write(array[j] + " ");
    }
}

int[] result = new int[8];
FillArray(result); 
PrintArray(result);

// ВАРИАНТ ответа с семинара: 

// int[] CreateArray()
// {
// int[] array = new int[8];
// var random = new Random();

// for (int i = 0; i < 8; i++)
// array[i] = random.Next(0, 2);

// return array;
// }

// var array = CreateArray();

// for (int i = 0; i < 8; i++)
// Console.WriteLine(array[i]);