// Задача 65   Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//             в промежутке от M до N.
//             Например:
//             M = 4; N = 8 -> "4, 5, 6, 7, 8" 

Console.Clear();

int numberM =  ReadData("Задайте число М");
int numberN =  ReadData("Задайте число N");

if(numberM < numberN)
{
    NaturalNumberPrinter(numberM, numberN);
}
else
{
    NaturalNumberPrinter(numberN, numberM);
}




int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

void NaturalNumberPrinter(int m, int n)
{
    if(m - 1 == n) return;
    Console.Write(m + " ");
    NaturalNumberPrinter(m+1, n);
}