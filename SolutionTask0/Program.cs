﻿// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя).
// Например: 4 -> 16 -3 -> 9 -7 -> 49 

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    //int outNumber = inputNumber * inputNumber;
    int outNumber = (int)Math.Pow(inputNumber,2);

    Console.WriteLine(outNumber);
}