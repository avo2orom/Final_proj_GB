/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.

Перовначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/


string[] newArrayP()
{
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] a = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите {0}-й элемент", i + 1);
        a[i] = Console.ReadLine();
    }
    return a;
}

//печать массива
void PrintArray(string[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write($", ");

    }
    Console.WriteLine();
}

string[] array = newArrayP();
PrintArray(array);