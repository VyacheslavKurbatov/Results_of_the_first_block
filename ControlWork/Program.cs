// Задача: Написать программу, 
// 1. которая из имеющегося массива строк 
// 2. формирует массив из строк, длина которых меньше либо равна 3 символа.

Console.WriteLine("Программа формирует массив из строк, длина которых меньше либо равна 3 символа.");

int n = InputNumber("Введите колличество слов, которое собиратесь ввести: ");
string[] arrayEnterData = FillArray(n);


PrintArray(arrayEnterData);

//Методы

void PrintArray(string[] array) // Печатает одномерный массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int InputNumber(string message) // Проверяет введеные данные
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine(), out int value);

        if (!result)
        {
            Console.WriteLine($"Введены некоректные данные. {message} еще раз!");
            Thread.Sleep(1500);
            continue;
        }

        if (value < 0)
        {
            Console.WriteLine($"Число не может быть отрицательным. {message} еще раз!");
            Thread.Sleep(1500);
            continue;
        }
        return value;
    }
}

string[] FillArray(int size)
{
    string[] arrayInpuyData = new string[size];
    Console.WriteLine("Введите слова через Enter");
    for (int i = 0; i < arrayInpuyData.Length; i++)
    {
        arrayInpuyData[i] = Console.ReadLine() ?? "null";
    }
    return arrayInpuyData;
}

