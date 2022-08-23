// Задача 63.  Задайте значение N. Напишите программу, которая выдаёт все натуральные числа в промежутке от 1 до N.
// Например:
// N = 5 -> "5, 4, 3, 2, 1"


Console.Clear();

int ReadData()
{
    Console.WriteLine("Задайте число");
    return int.Parse(Console.ReadLine());
}

int NaturalNumberPrinter(int num)
{
    // Делаем остановку нашего метода
    if(num == 2) return 1;
    else
    {
        num--;
        Console.WriteLine(num);
        Console.Write(NaturalNumberPrinter(num) + " ");
    }
    return num;
}

int inputNumber = ReadData();
NaturalNumberPrinter(inputNumber + 2);