﻿void printAnswer(int number)
{
    if(number==1) Console.WriteLine ("Допустимо: x>0, y>0");
    if(number==2) Console.WriteLine ("Допустимо: x<0, y>0");
    if(number==3) Console.WriteLine ("Допустимо: x<0, y<0");
    if(number==4) Console.WriteLine ("Допустимо: x>0, y<0");
}


string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    printAnswer(inputNumber);
}

// Вариант 1
// string? inputLine = Console.ReadLine();

// if(inputLine != null)
// {
//    int inputNumber = int.Parse(inputLine);

//    if(inputNumber==1) Console.WriteLine ("Допустимо: x>0, y>0");
//    if(inputNumber==2) Console.WriteLine ("Допустимо: x<0, y>0");
//    if(inputNumber==3) Console.WriteLine ("Допустимо: x<0, y<0");
//    if(inputNumber==4) Console.WriteLine ("Допустимо: x>0, y<0");
// }