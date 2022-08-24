// Задача 69    Напишите программу, которая на вход принимает два числа А и В,
//              и возводит число А в целую степень В с помощью рекурсии.

int inputNumberA = ReadNumber("Введите число А: ");
int inputNumberB = ReadNumber("Введите число B: ");

Console.WriteLine(PowNumber(inputNumberA, inputNumberB));
Console.WriteLine(MyPow(inputNumberA, inputNumberB));

int PowNumber(int a, int b)
{
    if(b == 1) return a;
    return a * PowNumber(a, --b);
}

int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}


// Метод преподавателя
int MyPow(int a, int b)
{
    if(b == 2)
    {
        return a * a;
    }
    if(b == 1)
    {
        return a;
    }
    // Вызов рекурсии
    if(b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2); 
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, (b / 2) + 1); 
    }
}