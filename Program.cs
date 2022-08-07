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