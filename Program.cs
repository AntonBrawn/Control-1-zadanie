/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами*/

using System;
using static System.Console;
Clear();
{
string[] array1 = new string[6] {"567", "2335", "team", "zeus", "ok", "simba"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int k = 0; k < array.Length; k++)
    {
        Console.Write($"{array[k]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
}