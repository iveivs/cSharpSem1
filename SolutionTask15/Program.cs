﻿// Задача 16
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
string? inputFirst = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? inputSecond = Console.ReadLine();

if ((inputFirst != null) && (inputSecond != null));
{
    int inputNumberFirst = int.Parse(inputFirst);
    int inputNumberSecond = int.Parse(inputSecond);
    int a = inputNumberFirst * inputNumberFirst;
    int b = inputNumberSecond * inputNumberSecond;
    if  ((a == inputNumberSecond) || (b == inputNumberFirst))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
